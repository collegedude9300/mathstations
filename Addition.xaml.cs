using System;
using System.Collections.Generic;
using Xamarin.Forms;
namespace MathStations
{
    public partial class Addition : ContentPage
    {
        public Addition()
        {
            InitializeComponent();
        }
        async void AddOne(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddLevOne());
        }
        async void AddTwo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddLevTwo());
        }
        async void AddThree(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddLevThree());
        }
        async void AddFour(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddLevFour());
        }
        async void BackToMain(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}
