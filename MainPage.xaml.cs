using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MathStations
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(MainPage)}: ctor");
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Addition());
        }
        async void SecondNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Subtraction());
        }
        async void ThirdNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Multiplication());
        }
        async void LastButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Division());
        }
    }
}