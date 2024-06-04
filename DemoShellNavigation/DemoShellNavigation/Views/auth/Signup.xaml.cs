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
    public partial class Signup : ContentPage
    {
        public Signup()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonPressed(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//login");
        }

        private async void OnSignupButtonClicked(object sender, EventArgs e) {
            await Shell.Current.GoToAsync("flow1");
        }
    }
}