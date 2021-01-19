using System;
using System.Collections.Generic;
using Xamarin.Forms;
namespace MathStations
{
    public partial class DivLevThree : ContentPage
    {
        public DivLevThree()
        {
            InitializeComponent();
        }
        async void ProbOne_DivLevThree(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 1", "150+150", maxLength: 3, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob1lev3div.Text = number == 300 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbTwo_DivLevThree(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 2", "400+140", maxLength: 3, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob2lev3div.Text = number == 540 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbThree_DivLevThree(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 3", "364+454", maxLength: 3, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob3lev3div.Text = number == 818 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbFour_DivLevThree(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 4", "580+480", maxLength: 4, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob4lev3div.Text = number == 1060 ? "Correct." : "Incorrect.";
            }
        }
        async void DivFour(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DivLevFour());
        }
        async void BackToHomeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Division());
        }
    }
}