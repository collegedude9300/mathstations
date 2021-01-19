using System;
using System.Collections.Generic;
using Xamarin.Forms;
namespace MathStations
{
    public partial class AddLevOne : ContentPage
    {
        public AddLevOne()
        {
            InitializeComponent();
        }
        async void ProbOne_AddLevOne(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 1", "5+5", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob1lev1add.Text = number == 10 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbTwo_AddLevOne(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 2", "7+4", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob2lev1add.Text = number == 11 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbThree_AddLevOne(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 3", "6+6", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob3lev1add.Text = number == 12 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbFour_AddLevOne(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 4", "8+8", maxLength: 2, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob4lev1add.Text = number == 16 ? "Correct." : "Incorrect.";
            }
        }
        async void AddTwo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddLevTwo());
        }        
        async void BackToHomeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Addition());
        }
    }
}
