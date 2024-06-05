using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoShellNavigation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            FirstnameEntry.Text = Preferences.Get("fname", "");
            LastnameEntry.Text = Preferences.Get("lname", "");
            EmailEntry.Text = Preferences.Get("email", "");
        }

        private void OnSaveButtonClicked(object sender, EventArgs e) {
            Preferences.Set("fname", FirstnameEntry.Text);
            Preferences.Set("lname", LastnameEntry.Text);
            Preferences.Set("email", EmailEntry.Text);
        }

        private void OnClearPreferences(object sender, EventArgs e) {
            Preferences.Clear();

            FirstnameEntry.Text = "";
            LastnameEntry.Text = "";
            EmailEntry.Text = "";
        }

        private async void onLogoutPress(object sender, EventArgs e) {
            await Shell.Current.GoToAsync("//login");
        }
    }
}