using DemoShellNavigation.Services;
using DemoShellNavigation.ViewModels;
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
    public partial class HomePage : ContentPage
    {
        private readonly BitcoinPriceService _bitcoinPriceService = new BitcoinPriceService();
        public HomePage()
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            var bitcoinPriceIndex = await _bitcoinPriceService.GetBitcoinPriceIndexAsync();

            UsdLabel.Text = $"USD: {bitcoinPriceIndex.bpi.USD.rate}";
            GbpLabel.Text = $"GBP: {bitcoinPriceIndex.bpi.GBP.rate}";
            EurLabel.Text = $"EUR: {bitcoinPriceIndex.bpi.EUR.rate}";
        }

        private void OnFetchNewPriceClicked(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}