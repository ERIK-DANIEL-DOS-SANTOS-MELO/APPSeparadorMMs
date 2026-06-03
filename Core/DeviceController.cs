using AppSeparadorMMs.Models;
using AppSeparadorMMs.Models.Enums;
using AppSeparadorMMs.Models.Interfaces;
using AppSeparadorMMs.Serial;

namespace AppSeparadorMMs.Core
{
    public sealed class DeviceController : IDisposable
    {
        private readonly SerialService _serialService;

        private Thread? _readThread;
        private bool _isRunning;

        public bool IsConnected => _serialService.IsConnected;

        public event EventHandler<DataMessage>? DataReceived;
        public event EventHandler<StatusMessage>? StatusReceived;
        public event EventHandler<CommandMessage>? CommandReceived;
        public event EventHandler<string>? RawMessageReceived;
        public event EventHandler<Exception>? ErrorOccurred;

        public DeviceController(SerialService serialService)
        {
            _serialService = serialService;
        }

        public void Connect()
        {
            if (IsConnected) return;

            _serialService.Connect();
            _isRunning = true;

            _readThread = new Thread(ReadLoop) { IsBackground = true };
            _readThread.Start();
        }

        public void Disconnect()
        {
            _isRunning = false;

            if (IsConnected) _serialService.Disconnect();
        }

        public void SendData(string data, double value)
        {
            var message = new DataMessage(ProtocolOwner.PC, data, value);

            Send(message);
        }

        public void SendCommand(string command, string? argument = null)
        {
            var message = new CommandMessage(ProtocolOwner.PC, command, argument);

            Send(message);
        }

        public void SendStatus(string status, string? details = null)
        {
            var message = new StatusMessage(ProtocolOwner.PC, status, details);

            Send(message);
        }

        public void Send(ISerialMessage message)
        {
            string raw = ProtocolWriter.Serialize(message);

            _serialService.Send(raw);
        }

        private void ReadLoop()
        {
            while (_isRunning)
            {
                try
                {
                    if (!IsConnected) continue;

                    string raw = _serialService.Receive();

                    RawMessageReceived?.Invoke(this, raw);

                    ISerialMessage? message = ProtocolReader.Parse(raw);

                    if (message is null) continue;

                    DispatchMessage(message);
                }

                catch (TimeoutException) { }

                catch (InvalidOperationException ex)
                {
                    ErrorOccurred?.Invoke(this, ex);
                }
                catch (IOException ex)
                {
                    ErrorOccurred?.Invoke(this, ex);
                }
                catch (Exception ex)
                {
                    ErrorOccurred?.Invoke(this, ex);
                }
            }
        }

        private void DispatchMessage(ISerialMessage message)
        {
            switch (message)
            {
                case DataMessage data:
                    DataReceived?.Invoke(this, data);
                    break;

                case StatusMessage status:
                    StatusReceived?.Invoke(this, status);
                    break;

                case CommandMessage command:
                    CommandReceived?.Invoke(this, command);
                    break;
            }
        }

        public void Dispose()
        {
            Disconnect();
            _serialService.Dispose();
        }
    }
}
