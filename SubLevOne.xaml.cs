using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MathStations
{
    public partial class SubLevOne : ContentPage
    {
        public SubLevOne()
        {
            InitializeComponent();
        }
        async void ProbOne_SubLevOne(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 1", "9-5", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob1lev1sub.Text = number == 4 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbTwo_SubLevOne(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 2", "12-3", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob2lev1sub.Text = number == 9 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbThree_SubLevOne(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 3", "16-5", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob3lev1sub.Text = number == 11 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbFour_SubLevOne(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 4", "24-1", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob4lev1sub.Text = number == 23 ? "Correct." : "Incorrect.";
            }
        }
        async void SubTwo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubLevTwo());
        }

        async void BackToHomeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Subtraction());
        }

    }
}
