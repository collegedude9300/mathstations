using System;
using System.Collections.Generic;
using Xamarin.Forms;
namespace MathStations
{
    public partial class DivLevTwo : ContentPage
    {
        public DivLevTwo()
        {
            InitializeComponent();
        }
        async void ProbOne_DivLevTwo(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 1", "28/2", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob1lev2div.Text = number == 14 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbTwo_DivLevTwo(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 2", "34/17", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob2lev2div.Text = number == 2 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbThree_DivLevTwo(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 3", "161/7", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob3lev2div.Text = number == 23 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbFour_DivLevTwo(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 4", "116/2", maxLength: 3, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob4lev2div.Text = number == 58 ? "Correct." : "Incorrect.";
            }
        }
        async void DivThree(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DivLevThree());
        }
        async void BackToHomeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Division());
        }
    }
}
