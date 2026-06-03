using System.IO.Ports;

namespace AppSeparadorMMs.Serial
{
    public sealed class SerialService : IDisposable
    {
        private readonly SerialPort _port;

        public bool IsConnected => _port.IsOpen;

        public SerialService(string portName, int baudRate)
        {
            _port = new SerialPort(portName, baudRate)
            {
                NewLine = "\n",
                ReadTimeout = 1000,
                WriteTimeout = 1000
            };
        }

        public void Connect()
        {
            if (!_port.IsOpen)
            {
                _port.Open();
            }
        }

        public void Disconnect()
        {
            if (_port.IsOpen)
            {
                _port.Close();
            }
        }

        public void Send(string message)
        {
            EnsureConnected();

            _port.WriteLine(message);
        }

        public string Receive()
        {
            EnsureConnected();

            return _port.ReadLine();
        }

        private void EnsureConnected()
        {
            if (!_port.IsOpen)
            {
                throw new InvalidOperationException("Serial port is not open.");
            }
        }

        public void Dispose()
        {
            Disconnect();
            _port.Dispose();
        }
    }
}
