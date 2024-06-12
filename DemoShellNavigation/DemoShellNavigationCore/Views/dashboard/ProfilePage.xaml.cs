using DemoShellNavigation.ViewModels;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

namespace DemoShellNavigation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        private ProfilePageViewModel profilePageViewModel;
        public ProfilePage()
        {
            InitializeComponent();
            profilePageViewModel = new ProfilePageViewModel();
            BindingContext = profilePageViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            profilePageViewModel.LoadData();
        }
    }
}