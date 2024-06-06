using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DemoShellNavigation.Droid;
using DemoShellNavigation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceInfoService))]
namespace DemoShellNavigation.Droid
{
    class DeviceInfoService : IDeviceInfoService
    {
        public string DeviceModel()
        {
            return Android.OS.Build.Model;
        }
    }
}