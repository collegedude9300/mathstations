using System;
using System.Collections.Generic;
using Xamarin.Forms;
namespace MathStations
{
    public partial class Division : ContentPage
    {
        public Division()
        {
            InitializeComponent();
        }
        async void DivOne(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DivLevOne());
        }
        async void DivTwo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DivLevTwo());
        }
        async void DivThree(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DivLevThree());
        }
        async void DivFour(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DivLevFour());
        }
        async void BackToMain(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
