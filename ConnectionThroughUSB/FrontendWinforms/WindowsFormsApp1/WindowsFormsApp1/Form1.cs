using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		SerialPort _serialPort = new SerialPort();

		public Form1()
		{
			InitializeComponent();
			groupBox1.Enabled = false;
		}

		private void btnSetPort_Click(object sender, EventArgs e)
		{
			_serialPort.PortName = txtComPort.Text;
			_serialPort.BaudRate = 115200;
			_serialPort.Open();

			if (_serialPort.IsOpen)
			{
				groupBox1.Enabled = true;
				btnSetPort.Enabled = false;
				txtComPort.Enabled = false;
				_serialPort.DataReceived += _serialPort_DataReceived;
			}
		}

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
		private void btnRelay0On_Click(object sender, EventArgs e) => _serialPort.WriteLine("Rellay0=1");
		private void btnRelay0Off_Click(object sender, EventArgs e) => _serialPort.WriteLine("Rellay0=0");
		private void btnRelay1On_Click(object sender, EventArgs e) => _serialPort.WriteLine("Rellay1=1");
		private void btnRelay1Off_Click(object sender, EventArgs e) => _serialPort.WriteLine("Rellay1=0");
		private void btnRelay2On_Click(object sender, EventArgs e) => _serialPort.WriteLine("Rellay2=1");
		private void btnRelay2Off_Click(object sender, EventArgs e) => _serialPort.WriteLine("Rellay2=0");
		private void btnRelay3On_Click(object sender, EventArgs e) => _serialPort.WriteLine("Rellay3=1");
		private void btnRelay3Off_Click(object sender, EventArgs e) => _serialPort.WriteLine("Rellay3=0");
		private void btnRelay4On_Click(object sender, EventArgs e) => _serialPort.WriteLine("Rellay4=1");
		private void btnRelay4Off_Click(object sender, EventArgs e) => _serialPort.WriteLine("Rellay4=0");
		private void btnRelay5On_Click(object sender, EventArgs e) => _serialPort.WriteLine("Rellay5=1");
		private void btnRelay5Off_Click(object sender, EventArgs e) => _serialPort.WriteLine("Rellay5=0");
		private void btnRelay6On_Click(object sender, EventArgs e) => _serialPort.WriteLine("Rellay6=1");
		private void btnRelay6Off_Click(object sender, EventArgs e) => _serialPort.WriteLine("Rellay6=0");
		private void btnRelay7On_Click(object sender, EventArgs e) => _serialPort.WriteLine("Rellay7=1");
		private void btnRelay7Off_Click(object sender, EventArgs e) => _serialPort.WriteLine("Rellay7=0");
		#endregion

		private void btnGetStatus_Click(object sender, EventArgs e) => _serialPort.WriteLine("GetStatus");
	}
}
