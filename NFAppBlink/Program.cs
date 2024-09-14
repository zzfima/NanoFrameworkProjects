//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

using System.Device.Gpio;
using System.Threading;

namespace Blinky
{
	public class Program
	{
		private static GpioController s_GpioController;
		public static void Main()
		{
			s_GpioController = new GpioController();
			GpioPin led = s_GpioController.OpenPin(2, PinMode.Output);
			led.Write(PinValue.Low);

			while (true)
			{
				led.Toggle();
				Thread.Sleep(125);
				led.Toggle();
				Thread.Sleep(125);
				led.Toggle();
				Thread.Sleep(125);
				led.Toggle();
				Thread.Sleep(525);
			}
		}
	}
}