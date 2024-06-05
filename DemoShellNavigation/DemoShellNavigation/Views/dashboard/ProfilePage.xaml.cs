using DemoShellNavigation.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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