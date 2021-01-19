using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MathStations
{
    public partial class Multiplication : ContentPage
    {
        public Multiplication()
        {
            InitializeComponent();
        }
        async void MultOne(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MultLevOne());
        }
        async void MultTwo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MultLevTwo());
        }
        async void MultThree(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MultLevThree());
        }
        async void MultFour(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MultLevFour());
        }
        async void BackToMain(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
