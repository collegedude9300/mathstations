using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MathStations
{
    public partial class Subtraction : ContentPage
    {
        public Subtraction()
        {
            InitializeComponent();
        }
        
        async void SubOne(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubLevOne());
        }
        async void SubTwo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubLevTwo());
        }
        async void SubThree(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubLevThree());
        }
        async void SubFour(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubLevFour());
        }
        
        async void BackToMain(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
