using DemoShellNavigation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace DemoShellNavigation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();

            var dependency = DependencyService.Get<IDeviceInfoService>();

            if (dependency != null) {
                DeviceInfoModel.Text = dependency.DeviceModel();
            }
        }
    }
}