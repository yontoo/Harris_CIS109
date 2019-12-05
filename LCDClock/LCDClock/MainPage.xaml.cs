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
using Windows.Devices.I2c;
using Windows.Devices.Enumeration;




// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LCDClock
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        
        public MainPage()
        {
            this.InitializeComponent();

        }

        public async void I2C()
        {
            //I2cDevice lcd = null;
            
            //// 0x27 is the I2C device address
            //var settings = new I2cConnectionSettings(0x27);
            //// FastMode = 400KHz
            //settings.BusSpeed = I2cBusSpeed.FastMode;

            //// Create an I2cDevice with the specified I2C settings
            //var controller = await I2cController.GetDefaultAsync();

            //string query = I2cDevice.GetDeviceSelector();
            //DeviceInformationCollection deviceInfo = await DeviceInformation.FindAllAsync(query);

            //lcd = await I2cDevice.FromIdAsync(deviceInfo[0].Id, settings);

            //lcd.Write(new byte[] { 0x80, 0x30 });

            //using (I2cDevice device = controller.GetDevice(settings))
            //{
            //    byte[] writeBuf = { 0x30 };
            //    device.Write(writeBuf);
            //}
        }


    }
}
