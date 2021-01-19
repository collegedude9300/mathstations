using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MathStations
{
    public partial class AddLevFour : ContentPage
    {
        public AddLevFour()
        {
            InitializeComponent();
        }
        async void ProbOne_AddLevFour(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 1", "1121+2121", maxLength: 4, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob1lev4add.Text = number == 3242 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbTwo_AddLevFour(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 2", "3456+1234", maxLength: 4, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob2lev4add.Text = number == 4690 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbThree_AddLevFour(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 3", "4564+9231", maxLength: 5, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob3lev4add.Text = number == 13795 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbFour_AddLevFour(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 4", "8000+9898", maxLength: 5, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob4lev4add.Text = number == 17898 ? "Correct." : "Incorrect.";
            }
        }
        async void BackToHomeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Addition());
        }
    }
}
