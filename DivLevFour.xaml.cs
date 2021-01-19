using System;
using System.Collections.Generic;
using Xamarin.Forms;
namespace MathStations
{
    public partial class DivLevFour : ContentPage
    {
        public DivLevFour()
        {
            InitializeComponent();
        }
        async void ProbOne_DivLevFour(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 1", "1500/2", maxLength: 4, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob1lev4div.Text = number == 750 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbTwo_DivLevFour(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 2", "3222/2", maxLength: 4, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob2lev4div.Text = number == 1611 ? "Correct." : "Incorrect.";
            }
        }
        async void ProbThree_DivLevFour(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 3", "4311/4", maxLength: 5, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob3lev4div.Text = number == 1077 ? "Correct." : "Incorrect.";
            }
            Console.WriteLine("remainder:3");
        }
        
        async void ProbFour_DivLevFour(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 4", "8837/7", maxLength: 5, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob4lev4div.Text = number == 1262 ? "Correct." : "Incorrect.";
            }
            Console.WriteLine("remainder:3 ");
        }
        async void BackToHomeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Division());
        }
    }
}
