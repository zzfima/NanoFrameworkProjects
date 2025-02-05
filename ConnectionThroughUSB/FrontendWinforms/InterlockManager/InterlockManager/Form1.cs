using System;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace InterlockManager
{
	public partial class Form1 : Form
	{
		SerialPort _serialPort = new SerialPort();

		public Form1()
		{
			InitializeComponent();
			groupBoxRellays.Enabled = false;
			groupBoxComPort.Enabled = true;
			InitializeComPorts();
		}

		private void InitializeComPorts()
		{
			foreach (string comPortName in SerialPort.GetPortNames())
				comboBoxComPorts.Items.Add(comPortName);

			comboBoxComPorts.SelectedIndex = 0;

			comboBoxComPorts.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		private void btnSetPort_Click(object sender, EventArgs e)
		{
			_serialPort.PortName = comboBoxComPorts.SelectedItem.ToString();
			_serialPort.BaudRate = 115200;
			_serialPort.Open();

			if (_serialPort.IsOpen)
			{
				groupBoxRellays.Enabled = true;
				groupBoxComPort.Enabled = false;
				_serialPort.DataReceived += _serialPort_DataReceived;
				Log($"Connected to {comboBoxComPorts.SelectedItem.ToString()}");
			}
		}

		private void Log(string v) => listBoxLogs.Items.Add($"{DateTime.Now.ToShortTimeString()} - {v}");

		private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			SerialPort sp = (SerialPort)sender;
			string indata = sp.ReadLine();

			lblStatus.Invoke(new MethodInvoker(() =>
			{
				lblStatus.Text = indata;
			}));
		}

		#region Relays
		private void btnRelay0_On_Click(object sender, EventArgs e)
		{
			RelaySetStatus(0, 1);
			RelaySetStatus(1, 1);
			Log($"Interlock On");
		}
		private void btnRelay0_Off_Click(object sender, EventArgs e)
		{
			RelaySetStatus(0, 0);
			RelaySetStatus(1, 0);
			Log($"Interlock Off");
		}
		private void btnRelay1_On_Click(object sender, EventArgs e) => RelaySetStatus(1, 1);
		private void btnRelay1_Off_Click(object sender, EventArgs e) => RelaySetStatus(1, 0);
		private void btnRelay2_On_Click(object sender, EventArgs e) => RelaySetStatus(2, 1);
		private void btnRelay2_Off_Click(object sender, EventArgs e) => RelaySetStatus(2, 0);
		private void btnRelay3_On_Click(object sender, EventArgs e) => RelaySetStatus(3, 1);
		private void btnRelay3_Off_Click(object sender, EventArgs e) => RelaySetStatus(3, 0);
		private void btnRelay4_On_Click(object sender, EventArgs e) => RelaySetStatus(4, 1);
		private void btnRelay4_Off_Click(object sender, EventArgs e) => RelaySetStatus(4, 0);

		private void RelaySetStatus(int relayNumber, int status) => _serialPort.WriteLine($"Rellay{relayNumber}={status}");
		#endregion

		private void btnGetStatus_Click(object sender, EventArgs e) => _serialPort.WriteLine("GetStatus");

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			StringBuilder help = new StringBuilder();
			help.AppendLine("1. Connect Interlock Manager Box wires in series to door switch. Do it with de-energized EFEM! There is 24V");
			help.AppendLine("2. Connect Interlock Manager Box USB to PC");
			help.AppendLine("3. In device manager find COM port of attached Interlock Manager Box");
			help.AppendLine("4. In current Software Application set this COM port and click 'Set COM port' button");
			help.AppendLine("5. Control buttons:");
			help.AppendLine("*** 'Interlock On' create Interlock");
			help.AppendLine("*** 'Interlock Off' stop Interlock");
			help.AppendLine("*** 'Get Relay Statuses' display relay statuses");
			MessageBox.Show(help.ToString());
		}
	}
}
