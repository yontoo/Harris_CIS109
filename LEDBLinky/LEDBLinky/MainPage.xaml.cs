using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Devices.Gpio;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LEDBLinky
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private const int LED_PIN = 5;
        private GpioPin p;
        private GpioPinValue pVal;
        private DispatcherTimer t;

        public MainPage()
        {
            this.InitializeComponent();

            t = new DispatcherTimer();
            t.Interval = TimeSpan.FromMilliseconds(250);
            t.Tick += T_Tick;

            GPIOInit();

            if (p != null)
            {
                t.Start();
            }

        }

        private void T_Tick(object sender, object e)
        {
            //flip value of pin (on/off state)
            if (pVal == GpioPinValue.High)
            {
                pVal = GpioPinValue.Low;
                p.Write(pVal);
            }

            else
            {
                pVal = GpioPinValue.High;
                p.Write(pVal);
            }
        }

        private void GPIOInit()
        {
            GpioController gpio = GpioController.GetDefault();

            if (gpio == null)
            {
                //kill program if no gpio controller
                p = null;
                return;
            }

            p = gpio.OpenPin(LED_PIN);
            pVal = GpioPinValue.High;
            p.Write(pVal);
            p.SetDriveMode(GpioPinDriveMode.Output);
        
        }
    }
}
