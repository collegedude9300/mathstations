using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MathStations
{
    public partial class MultLevTwo : ContentPage
    {
        public MultLevTwo()
        {
            InitializeComponent();
        }
        async void ProbOne_MultLevTwo(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 1", "12x5", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob1lev2mult.Text = number == 60 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbTwo_MultLevTwo(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 2", "12x8", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob2lev2mult.Text = number == 96 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbThree_MultLevTwo(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 3", "13x2", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob3lev2mult.Text = number == 26 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbFour_MultLevTwo(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 4", "13x5", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob4lev2mult.Text = number == 65 ? "Correct." : "Incorrect.";
            }
        }
        async void MultThree(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MultLevThree());
        }
        async void BackToHomeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Addition());
        }
    }
}
