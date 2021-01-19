using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MathStations
{
    public partial class AddLevTwo : ContentPage
    {
        public AddLevTwo()
        {
            InitializeComponent();
        }
        async void ProbOne_AddLevTwo(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 1", "15+15", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob1lev2add.Text = number == 30 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbTwo_AddLevTwo(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 2", "17+14", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob2lev2add.Text = number == 31 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbThree_AddLevTwo(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 3", "36+36", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob3lev2add.Text = number == 72 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbFour_AddLevTwo(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 4", "58+48", maxLength: 3, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob4lev2add.Text = number == 106 ? "Correct." : "Incorrect.";
            }
        }
        async void AddThree(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddLevThree());
        }
        async void BackToHomeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Addition());
        }
    }
}
