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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void OnSignupButton(object sender, EventArgs e) {
            await Shell.Current.GoToAsync("//signup");
        }

        private async void OnLoginPress(object sender, EventArgs e) {
            await Shell.Current.GoToAsync("//home");
        }
    }
}