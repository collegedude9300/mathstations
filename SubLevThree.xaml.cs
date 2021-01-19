using System;
using System.Collections.Generic;
using Xamarin.Forms;
namespace MathStations
{
    public partial class SubLevThree : ContentPage
    {
        public SubLevThree()
        {
            InitializeComponent();
        }
        async void ProbOne_SubLevThree(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 1", "40-19", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob1lev3sub.Text = number == 21 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbTwo_SubLevThree(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 2", "57-38", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob2lev3sub.Text = number == 19 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbThree_SubLevThree(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 3", "71-59", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob3lev3sub.Text = number == 12 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbFour_SubLevThree(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 4", "81-59", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob4lev3sub.Text = number == 22 ? "Correct." : "Incorrect.";
            }
        }
        async void SubFour(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SubLevFour());
        }

        async void BackToHomeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Subtraction());
        }
    }
}
