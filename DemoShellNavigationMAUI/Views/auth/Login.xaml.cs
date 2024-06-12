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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void OnSignupButtonClicked(object sender, EventArgs e) {
            await Shell.Current.GoToAsync("//signup");
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e) {
            await Shell.Current.GoToAsync("//home");
        }
    }
}