using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		SerialPort _serialPort = new SerialPort();

		public Form1()
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

		private void btnBlinkThreeTimes_Click_1(object sender, EventArgs e)
		{
			_serialPort.Write("c");
		}

		private void btnCloseCircuit_Click_1(object sender, EventArgs e)
		{
			_serialPort.Write("a");
		}

		private void btnOpenCircuit_Click_1(object sender, EventArgs e)
		{
			_serialPort.Write("b");
		}
	}
}
