using DemoShellNavigation.Interfaces;
using DemoShellNavigation.iOS;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceInfoService))]
namespace DemoShellNavigation.iOS
{
    class DeviceInfoService : IDeviceInfoService
    {
        public string DeviceModel()
        {
            return UIKit.UIDevice.CurrentDevice.Model;
        }
    }
}