using DemoShellNavigation.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoShellNavigation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchPage : ContentPage
    {
        public ObservableCollection<Note> Notes { get; set; }

        public SearchPage()
        {
            InitializeComponent();

            Notes = new ObservableCollection<Note>
            {
                new Note { Description = "Task 1 Description" },
                new Note { Description = "Task 2 Description" },
                new Note { Description = "Task 3 Description" }
            };

            BindingContext = this;
        }
    }
}