using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MathStations
{
    public partial class MultLevThree : ContentPage
    {
        public MultLevThree()
        {
            InitializeComponent();
        }
        
        async void ProbOne_MultLevThree(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 1", "15x15", maxLength: 3, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob1lev3mult.Text = number == 225 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbTwo_MultLevThree(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 2", "23x48", maxLength: 5, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob2lev3mult.Text = number == 1104 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbThree_MultLevThree(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 3", "36x63", maxLength: 5, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob3lev3mult.Text = number == 2268 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbFour_MultLevThree(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 4", "58x40", maxLength: 5, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob4lev3mult.Text = number == 2320 ? "Correct." : "Incorrect.";
            }
        }
        async void MultFour(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MultLevFour());
        }
        async void BackToHomeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Multiplication());
        }
    }
}
