using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MathStations
{
    public partial class MultLevFour : ContentPage
    {
        public MultLevFour()
        {
            InitializeComponent();
        }
        async void ProbOne_MultLevFour(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 1", "822x9", maxLength: 5, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob1lev4mult.Text = number == 7398 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbTwo_MultLevFour(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 2", "637*6", maxLength: 5, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob2lev4mult.Text = number == 3822 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbThree_MultLevFour(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 3", "994*9", maxLength: 5, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob3lev4mult.Text = number == 8946 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbFour_MultLevFour(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 4", "208*52", maxLength: 5, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob4lev4mult.Text = number == 10816 ? "Correct." : "Incorrect.";
            }
        }
        async void BackToHomeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Multiplication());
        }
    }
}
