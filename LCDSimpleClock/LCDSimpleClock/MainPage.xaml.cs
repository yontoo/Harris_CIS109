/*  Uses Jaroslav Živný's code to connect to the LCD over I2C
 *  https://github.com/DzeryCZ/Character-LCD-over-I2C */


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
using displayI2C;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LCDSimpleClock
{
    
    public sealed partial class MainPage : Page
    {
        DispatcherTimer t = new DispatcherTimer();

        //Setup address
        private const string I2C_CONTROLLER_NAME = "I2C1"; //use for RPI2
        private const byte DEVICE_I2C_ADDRESS = 0x27; // 7-bit I2C address of the port expander

        //Setup pins
        private const byte EN = 0x02;
        private const byte RW = 0x01;
        private const byte RS = 0x00;
        private const byte D4 = 0x04;
        private const byte D5 = 0x05;
        private const byte D6 = 0x06;
        private const byte D7 = 0x07;
        private const byte BL = 0x03;

        displayI2C.displayI2C lcd = new displayI2C.displayI2C(DEVICE_I2C_ADDRESS, I2C_CONTROLLER_NAME, RS, RW, EN, D4, D5, D6, D7, BL);


        public MainPage()
        {
            this.InitializeComponent();
            start();
        }

        private void start()
        {
            t.Interval = TimeSpan.FromSeconds(1);
            t.Tick += Tick;
            t.Start();
            this.lcd.init();

        }


        private void Tick(object sender, object e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            bool pm = false;

            string time = "";
            string date = DateTime.Now.ToString("MMM dd yyyy");

            if (hh > 12)
            {
                hh -= 12;
                pm = true;
            }

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }

            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }

            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            if (pm)
            {
                time += " PM";
            }
            else
            {
                time += " AM";
            }


            this.lcd.clrscr();
            this.lcd.prints(date);
            this.lcd.gotoxy(0, 1);
            this.lcd.prints(time);
            

        }
    }
}
