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
//using Windows.Devices.Gpio;
//using Windows.Devices.I2c;
//using Windows.Devices.Enumeration;
using WiringPi;





// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LCDClock
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        int LCDAddr = 0x27;
        int BLEN = 1;
        int fd;

        public MainPage()
        {
            this.InitializeComponent();
            main();
        }



        public void write_word(int data)
        {
            int temp = data;
            if (BLEN == 1)
                temp |= 0x08;
            else
                temp &= 0xF7;
            WiringPi.I2C.wiringPiI2CWrite(fd, temp);
        }

        public void send_command(int comm)
        {
            int buf;
            // Send bit7-4 firstly
            buf = comm & 0xF0;
            buf |= 0x04;            // RS = 0, RW = 0, EN = 1
            write_word(buf);
            WiringPi.Timing.delay(2);
            buf &= 0xFB;            // Make EN = 0
            write_word(buf);

            // Send bit3-0 secondly
            buf = (comm & 0x0F) << 4;
            buf |= 0x04;            // RS = 0, RW = 0, EN = 1
            write_word(buf);
            WiringPi.Timing.delay(2);
            buf &= 0xFB;            // Make EN = 0
            write_word(buf);
        }

        public void send_data(int data)
        {
            int buf;
            // Send bit7-4 firstly
            buf = data & 0xF0;
            buf |= 0x05;            // RS = 1, RW = 0, EN = 1
            write_word(buf);
            WiringPi.Timing.delay(2);
            buf &= 0xFB;            // Make EN = 0
            write_word(buf);

            // Send bit3-0 secondly
            buf = (data & 0x0F) << 4;
            buf |= 0x05;            // RS = 1, RW = 0, EN = 1
            write_word(buf);
            WiringPi.Timing.delay(2);
            buf &= 0xFB;            // Make EN = 0
            write_word(buf);
        }

        public void init()
        {
            send_command(0x33); // Must initialize to 8-line mode at first
            WiringPi.Timing.delay(5);
            send_command(0x32); // Then initialize to 4-line mode
            WiringPi.Timing.delay(5);
            send_command(0x28); // 2 Lines & 5*7 dots
            WiringPi.Timing.delay(5);
            send_command(0x0C); // Enable display without cursor
            WiringPi.Timing.delay(5);
            send_command(0x01); // Clear Screen
            WiringPi.I2C.wiringPiI2CWrite(fd, 0x08);
        }

        public void clear()
        {
            send_command(0x01); //clear Screen
        }

        public void write(int x, int y, char[] data)
        {
            int addr, i;
            int tmp;
            if (x < 0) x = 0;
            if (x > 15) x = 15;
            if (y < 0) y = 0;
            if (y > 1) y = 1;

            // Move cursor
            addr = 0x80 + 0x40 * y + x;
            send_command(addr);

            tmp = data.Length;
            for (i = 0; i < tmp; i++)
            {
                send_data(data[i]);
            }
        }


        public void main()
        {
            string line1 = "Greetings!";
            string line2 = "From SunFounder";
            fd = WiringPi.I2C.wiringPiI2CSetup(LCDAddr);
            init();
            write(0, 0, line1.ToCharArray());
            write(1, 1, line2.ToCharArray());
            WiringPi.Timing.delay(2000);
            clear();
        }
















        //public async void I2C()
        //{
        //    //I2cDevice lcd = null;

        //    //// 0x27 is the I2C device address
        //    //var settings = new I2cConnectionSettings(0x27);
        //    //// FastMode = 400KHz
        //    //settings.BusSpeed = I2cBusSpeed.FastMode;

        //    //// Create an I2cDevice with the specified I2C settings
        //    //var controller = await I2cController.GetDefaultAsync();

        //    //string query = I2cDevice.GetDeviceSelector();
        //    //DeviceInformationCollection deviceInfo = await DeviceInformation.FindAllAsync(query);

        //    //lcd = await I2cDevice.FromIdAsync(deviceInfo[0].Id, settings);

        //    //lcd.Write(new byte[] { 0x80, 0x30 });

        //    //using (I2cDevice device = controller.GetDevice(settings))
        //    //{
        //    //    byte[] writeBuf = { 0x30 };
        //    //    device.Write(writeBuf);
        //    //}
        //}


    }
}
