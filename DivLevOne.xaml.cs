using System;
using System.Collections.Generic;
using Xamarin.Forms;
namespace MathStations
{
    public partial class DivLevOne : ContentPage
    {
        public DivLevOne()
        {
            InitializeComponent();
        }
        async void ProbOne_DivLevOne(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 1", "5/5", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob1lev1div.Text = number == 1 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbTwo_DivLevOne(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 2", "8/4", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob2lev1div.Text = number == 2 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbThree_DivLevOne(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 3", "12/6", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob3lev1div.Text = number == 3 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbFour_DivLevOne(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 4", "72/9", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob4lev1div.Text = number == 8 ? "Correct." : "Incorrect.";
            }
        }
        async void DivTwo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DivLevTwo());
        }
        async void BackToHomeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Division());
        } 
    }
}
