﻿using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
		private void btnRelay0_On_Click(object sender, EventArgs e) => RelaySetStatus(0, 1);
		private void btnRelay0_Off_Click(object sender, EventArgs e) => RelaySetStatus(0, 0);
		private void btnRelay1_On_Click(object sender, EventArgs e) => RelaySetStatus(1, 1);
		private void btnRelay1_Off_Click(object sender, EventArgs e) => RelaySetStatus(1, 0);
		private void btnRelay2_On_Click(object sender, EventArgs e) => RelaySetStatus(2, 1);
		private void btnRelay2_Off_Click(object sender, EventArgs e) => RelaySetStatus(2, 0);
		private void btnRelay3_On_Click(object sender, EventArgs e) => RelaySetStatus(3, 1);
		private void btnRelay3_Off_Click(object sender, EventArgs e) => RelaySetStatus(3, 0);
		private void btnRelay4_On_Click(object sender, EventArgs e) => RelaySetStatus(4, 1);
		private void btnRelay4_Off_Click(object sender, EventArgs e) => RelaySetStatus(4, 0);
		private void btnRelay5_On_Click(object sender, EventArgs e) => RelaySetStatus(5, 1);
		private void btnRelay5_Off_Click(object sender, EventArgs e) => RelaySetStatus(5, 0);
		private void btnRelay6_On_Click(object sender, EventArgs e) => RelaySetStatus(6, 1);
		private void btnRelay6_Off_Click(object sender, EventArgs e) => RelaySetStatus(6, 0);
		private void btnRelay7_On_Click(object sender, EventArgs e) => RelaySetStatus(7, 1);
		private void btnRelay7_Off_Click(object sender, EventArgs e) => RelaySetStatus(7, 0);

		private void RelaySetStatus(int relayNumber, int status) => _serialPort.WriteLine($"Rellay{relayNumber}={status}");
		#endregion

		private void btnGetStatus_Click(object sender, EventArgs e) => _serialPort.WriteLine("GetStatus");
	}
}
