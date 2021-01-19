using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MathStations
{
    public partial class SubLevFour : ContentPage
    {
        public SubLevFour()
        {
            InitializeComponent();
        }
        async void ProbOne_SubLevFour(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 1", "432-151", maxLength: 4, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob1lev4sub.Text = number == 281 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbTwo_SubLevFour(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 2", "501-399", maxLength: 4, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob2lev4sub.Text = number == 102 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbThree_SubLevFour(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 3", "4564-1111", maxLength: 5, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob3lev4sub.Text = number == 3453 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbFour_SubLevFour(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 4", "8000-2926", maxLength: 5, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob4lev4sub.Text = number == 5074 ? "Correct." : "Incorrect.";
            }
        }
        async void BackToHomeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Subtraction());
        }
    }
}
