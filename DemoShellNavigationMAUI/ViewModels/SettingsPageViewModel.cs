using DemoShellNavigation.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#if __ANDROID__
using DemoShellNavigationMAUI.Platforms.Android;
#endif
#if __IOS__
using DemoShellNavigationMAUI.Platforms.iOS;
#endif

namespace DemoShellNavigationMAUI.ViewModels
{
    public class SettingsPageViewModel: INotifyPropertyChanged
    {
        private readonly IDeviceInfoService _deviceInfoService;

        public SettingsPageViewModel()
        {
#if __ANDROID__
                    DeviceInfoService deviceInfoService = new DeviceInfoService();
                    DeviceModel = deviceInfoService.GetDeviceModel();
#endif
#if __IOS__
            DeviceInfoService deviceInfoService = new DeviceInfoService();
            DeviceModel = deviceInfoService.GetDeviceModel();
#endif

        }

        private string _deviceModel;

        public string DeviceModel
        {
            get => _deviceModel;
            set
            {
                if (_deviceModel != value)
                {
                    _deviceModel = value;
                    OnPropertyChanged(nameof(DeviceModel));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
