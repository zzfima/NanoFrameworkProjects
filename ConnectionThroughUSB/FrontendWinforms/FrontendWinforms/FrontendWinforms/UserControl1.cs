using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace FrontendWinforms
{
	public partial class UserControl1 : UserControl
	{
		SerialPort _serialPort = new SerialPort();

		public UserControl1()
		{
			InitializeComponent();
			btnBlinkThreeTimes.Enabled = false;
			btnCloseCircuit.Enabled = false;
			btnOpenCircuit.Enabled = false;
		}

		private void btnSetPort_Click(object sender, EventArgs e)
		{
			_serialPort.PortName = txtComPort.Text;
			_serialPort.BaudRate = 115200;
			_serialPort.Open();

			btnBlinkThreeTimes.Enabled = true;
			btnCloseCircuit.Enabled = true;
			btnOpenCircuit.Enabled = true;
		}

		private void btnBlinkThreeTimes_Click(object sender, EventArgs e)
		{
			_serialPort.Write("c");
		}

		private void btnCloseCircuit_Click(object sender, EventArgs e)
		{
			_serialPort.Write("a");
		}

		private void btnOpenCircuit_Click(object sender, EventArgs e)
		{
			_serialPort.Write("b");
		}
	}
}
