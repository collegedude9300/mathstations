using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MathStations
{
    public partial class SubLevTwo : ContentPage
    {
        public SubLevTwo()
        {
            InitializeComponent();
        }
        async void ProbOne_SubLevTwo(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 1", "45-15", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob1lev2sub.Text = number == 30 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbTwo_SubLevTwo(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 2", "62-21", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob2lev2sub.Text = number == 41 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbThree_SubLevTwo(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 3", "99-18", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob3lev2sub.Text = number == 81 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbFour_SubLevTwo(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 4", "88-53", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob4lev2sub.Text = number == 35 ? "Correct." : "Incorrect.";
            }
        }
        async void SubThree(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubLevThree());
        }

        async void BackToHomeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Subtraction());
        }
    }
}
