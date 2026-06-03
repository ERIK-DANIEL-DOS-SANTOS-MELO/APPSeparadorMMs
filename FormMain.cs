using AppSeparadorMMs.Core;
using AppSeparadorMMs.Models;
using AppSeparadorMMs.Serial;
using System.Globalization;
using System.IO.Ports;

namespace AppSeparadorMMs
{
    public partial class FormMain : Form
    {
        private SerialService? _serial;
        private DeviceController? _device;

        public FormMain()
        {
            InitializeComponent();

            toolStripComboBox_Ports.Items.AddRange(SerialPort.GetPortNames());
            if (toolStripComboBox_Ports.Items.Count > 0)
            {
                toolStripComboBox_Ports.SelectedIndex = 0;
            }

            toolStripLabel_Status.Text = "Desconectado";
        }

        private void toolStripButton_RefreshPort_Click(object sender, EventArgs e)
        {
            toolStripComboBox_Ports.Items.Clear();

            toolStripComboBox_Ports.Items.AddRange(SerialPort.GetPortNames());
            if (toolStripComboBox_Ports.Items.Count > 0)
            {
                toolStripComboBox_Ports.SelectedIndex = 0;
            }
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            if (_serial is null)
            {
                try
                {
                    string? selectedPort = toolStripComboBox_Ports.SelectedItem?.ToString();
                    if (string.IsNullOrWhiteSpace(selectedPort))
                    {
                        MessageBox.Show("Selecione uma porta serial antes de conectar.", "Porta serial", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    _serial = new SerialService(selectedPort, 9600);

                    _device = new DeviceController(_serial);
                    _device.DataReceived += Device_DataReceived;
                    _device.CommandReceived += Device_CommandReceived;
                    _device.StatusReceived += Device_StatusReceived;
                    _device.RawMessageReceived += Device_RawMessageReceived;
                    _device.ErrorOccurred += Device_ErrorOccurred;

                    _device.Connect();

                    toolStripLabel_Status.Text = "Conectado";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao conectar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    _serial?.Dispose();
                    _serial = null;
                    _device = null;
                }
            }
        }

        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            _device?.Dispose();

            _device = null;
            _serial = null;

            toolStripLabel_Status.Text = "Desconectado";
            button_Start.Text = "Iniciar";
        }

        private void Device_RawMessageReceived(object? sender, string raw)
        {
            SafeUI(() => Console.WriteLine($"RAW: {raw}"));
        }

        private void Device_DataReceived(object? sender, DataMessage data)
        {
            SafeUI(() =>
            {
                Console.WriteLine($"DATA: {data.Data} = {data.Value}");
                UpdateDataDisplay(data);
            });
        }

        private void Device_CommandReceived(object? sender, CommandMessage command)
        {
            SafeUI(() => Console.WriteLine($"COMMAND: {command.Command}({command.Argument})"));
        }

        private void Device_StatusReceived(object? sender, StatusMessage status)
        {
            SafeUI(() =>
            {
                Console.WriteLine($"STATUS: {status.Status}");
                UpdateStatusDisplay(status);
            });
        }

        private void Device_ErrorOccurred(object? sender, Exception error)
        {
            SafeUI(() =>
            {
                Console.WriteLine($"ERROR: {error.Message}");
                toolStripLabel_Status.Text = "Erro de comunicacao";
            });
        }

        private void SafeUI(Action action)
        {
            if (IsDisposed || Disposing) return;

            if (InvokeRequired)
            {
                try
                {
                    BeginInvoke(action);
                }
                catch (InvalidOperationException)
                {
                }
            }
            else
                action();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _device?.Dispose();

            _device = null;
            _serial = null;
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (!(_device?.IsConnected ?? false))
            {
                MessageBox.Show("Conecte o controlador antes de iniciar.", "Controlador", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isStarting = button_Start.Text == "Iniciar";
            _device.SendCommand(isStarting ? DeviceCommandNames.Start : DeviceCommandNames.Stop);
            button_Start.Text = isStarting ? "Parar" : "Iniciar";
        }

        private void button_SaveChanges_Click(object sender, EventArgs e)
        {
            if (!(_device?.IsConnected ?? false))
            {
                MessageBox.Show("Conecte o controlador antes de salvar as configuracoes.", "Controlador", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _device.SendCommand(DeviceCommandNames.SetThreshold, trackBar_Threshold.Value.ToString());
            _device.SendCommand(DeviceCommandNames.SetInterval, trackBar_Interval.Value.ToString());
        }

        private void UpdateDataDisplay(DataMessage data)
        {
            switch (data.Data)
            {
                case DeviceDataNames.LightCount:
                    numericUpDown_LightCounter.Value = ClampCounterValue(data.Value, numericUpDown_LightCounter);
                    break;

                case DeviceDataNames.DarkCount:
                    numericUpDown_DarkCounter.Value = ClampCounterValue(data.Value, numericUpDown_DarkCounter);
                    break;

                case DeviceDataNames.Uptime:
                    label_Timer.Text = FormatUptimeMilliseconds(data.Value);
                    break;
            }
        }

        private void UpdateStatusDisplay(StatusMessage status)
        {
            switch (status.Status)
            {
                case "On":
                    toolStripLabel_Status.Text = "Conectado - rodando";
                    button_Start.Text = "Parar";
                    break;

                case "Off":
                    toolStripLabel_Status.Text = "Conectado - parado";
                    button_Start.Text = "Iniciar";
                    break;

                case "Threshold":
                    SetConfigurationValue(trackBar_Threshold, label_ActualThreshold, status.Details);
                    break;

                case "Interval":
                    SetConfigurationValue(trackBar_Interval, label_ActualInterval, status.Details);
                    break;

                case "Error":
                    toolStripLabel_Status.Text = $"Erro: {status.Details ?? "desconhecido"}";
                    break;
            }
        }

        private static decimal ClampCounterValue(double value, NumericUpDown target)
        {
            if (double.IsNaN(value) || double.IsInfinity(value)) return target.Minimum;

            double roundedValue = Math.Round(value);
            if (roundedValue <= (double)target.Minimum) return target.Minimum;
            if (roundedValue >= (double)target.Maximum) return target.Maximum;

            return Convert.ToDecimal(roundedValue);
        }

        private static void SetConfigurationValue(TrackBar trackBar, Label actualValueLabel, string? value)
        {
            if (!int.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out int parsedValue)) return;

            trackBar.Value = Math.Min(trackBar.Maximum, Math.Max(trackBar.Minimum, parsedValue));
            actualValueLabel.Text = $"({parsedValue.ToString(CultureInfo.InvariantCulture)})";
        }

        private static string FormatUptimeMilliseconds(double milliseconds)
        {
            if (double.IsNaN(milliseconds) || double.IsInfinity(milliseconds) || milliseconds < 0) milliseconds = 0;

            return TimeSpan.FromMilliseconds(milliseconds).ToString(@"mm\:ss");
        }
    }
}
