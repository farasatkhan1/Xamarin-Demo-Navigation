using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoShellNavigation.Views.auth.onboarding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignupFlow1 : ContentPage
    {
        public SignupFlow1()
        {
            InitializeComponent();
        }

        private async void onFlowClicked(object sender, EventArgs e) {
            await Shell.Current.GoToAsync("flow2");
        }
    }
}