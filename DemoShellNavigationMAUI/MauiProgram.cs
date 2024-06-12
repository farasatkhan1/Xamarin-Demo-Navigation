using Microsoft.Extensions.Logging;
using DemoShellNavigation;
using DemoShellNavigation.Interfaces;
using DemoShellNavigation.Controls;
using Microsoft.Maui.Controls.Compatibility.Hosting;
using DemoShellNavigationMAUI.ViewModels;

#if __ANDROID__
using DemoShellNavigationMAUI.Platforms.Android;
#endif

namespace DemoShellNavigationMAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .ConfigureMauiHandlers(handlers => {
#if __ANDROID__
                        handlers.AddCompatibilityRenderer(typeof(CustomButton), typeof(DemoShellNavigation.CustomRendererAndroid.CustomButtonRenderer));
#endif
                    //#if __IOS__
                    //    handlers.AddCompatibilityRenderer(typeof(CustomButton), typeof(DemoShellNavigation.CustomRendererIOS.CustomButtonRenderer));
                    //#endif
                })
                .UseMauiCompatibility();

#if __ANDROID__
            builder.Services.AddSingleton<IDeviceInfoService, DeviceInfoService>();
#endif

            builder.Services.AddTransient<SettingsPageViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
