using nanoFramework.Networking;
using nanoFramework.Logging;
using System;
using System.Device.Gpio;
using System.Threading;
using nanoFramework.Logging.Serial;
using Microsoft.Extensions.Logging;
using System.IO.Ports;
using nanoFramework.Hardware.Esp32;

namespace NFAppTemperaturePressureAzureIoT
{
	public class Program
	{
		private static int sleepTimeMilliseconds = 60000;
		private static GpioController s_GpioController;
		private static SerialLogger logger = null;
		private static Secrets secrets = new Secrets();
		private static readonly int minutesToGoToSleep = 2;

		public static void Main()
		{
			Init();
			new Thread(Blink).Start();
			ConnectToWifi();
		}

		private static void Init()
		{
			SerialPort serial = new(secrets.ComPort);
			serial.BaudRate = 115200;
			logger = new SerialLogger(ref serial, "My logger");
			logger.MinLogLevel = LogLevel.Debug;
			Trace("Program Started, connecting to Wifi.");
		}

		private static void ConnectToWifi()
		{

			CancellationTokenSource cs = new(sleepTimeMilliseconds);
			var success = NetworkHelper.ConnectWifiDhcp(secrets.Ssid, secrets.Password, setDateTime: true, token: cs.Token);
			if (!success)
			{
				Trace($"Can't connect to wifi: {NetworkHelper.ConnectionError.Error}");
				if (NetworkHelper.ConnectionError.Exception != null)
				{
					Trace($"NetworkHelper.ConnectionError.Exception");
				}

				GoToSleep();
			}
		}

		private static void GoToSleep()
		{
			Sleep.EnableWakeupByTimer(new TimeSpan(0, 0, minutesToGoToSleep, 0));
			Sleep.StartDeepSleep();
		}

		static void Trace(string message)
		{
			logger?.LogDebug(message);
		}

		private static void Blink()
		{
			s_GpioController = new GpioController();
			GpioPin led = s_GpioController.OpenPin(2, PinMode.Output);
			led.Write(PinValue.Low);

			while (true)
			{
				led.Toggle();
				Thread.Sleep(1000);
			}
		}
	}
}
