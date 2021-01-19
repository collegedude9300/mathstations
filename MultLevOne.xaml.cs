using System;
using System.Collections.Generic;
using Xamarin.Forms;
namespace MathStations
{
    public partial class MultLevOne : ContentPage
    {
        public MultLevOne()
        {
            InitializeComponent();
        }
        async void ProbOne_MultLevOne(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 1", "5x5", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob1lev1mult.Text = number == 25 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbTwo_MultLevOne(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 2", "7x4", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob2lev1mult.Text = number == 28 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbThree_MultLevOne(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 3", "6x6", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob3lev1mult.Text = number == 36 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbFour_MultLevOne(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 4", "8x8", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob4lev1mult.Text = number == 64 ? "Correct." : "Incorrect.";
            }
        }
        async void MultTwo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MultLevTwo());
        }
        async void BackToHomeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Multiplication());
        }
    }
}
