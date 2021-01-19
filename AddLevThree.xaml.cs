using System;
using System.Collections.Generic;
using Xamarin.Forms;
namespace MathStations
{
    public partial class AddLevThree : ContentPage
    {
        public AddLevThree()
        {
            InitializeComponent();
        }
        async void ProbOne_AddLevThree(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 1", "29/4", maxLength: 3, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob1lev3add.Text = number == 7 ? "Correct." : "Incorrect.";
                Console.WriteLine("remainder: 1");
            }
        }
        async void ProbTwo_AddLevThree(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 2", "98/6", maxLength: 3, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob2lev3add.Text = number == 16 ? "Correct." : "Incorrect.";
                Console.WriteLine("remainder: 2");
            }
        }
        async void ProbThree_AddLevThree(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 3", "364/9", maxLength: 3, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob3lev3add.Text = number == 40 ? "Correct." : "Incorrect.";
                Console.WriteLine("remainder: 4");
            }
        }
        async void ProbFour_AddLevThree(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync("Question 4", "580/8", maxLength: 4, keyboard: Keyboard.Numeric);
            if (!string.IsNullOrWhiteSpace(result))
            {
                int number = Convert.ToInt32(result);
                prob4lev3add.Text = number == 72 ? "Correct." : "Incorrect.";
                Console.WriteLine("remainder: 4");
            }
        }
        async void AddFour(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddLevFour());
        }
        async void BackToHomeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Addition());
        }
    }
}
