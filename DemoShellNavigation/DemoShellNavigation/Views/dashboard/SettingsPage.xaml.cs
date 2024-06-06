using DemoShellNavigation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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