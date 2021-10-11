using System;

namespace PrimeNumber.Views
{
    public static class MainMenuView
    {
        /// <summary>
        /// The main menu view with four diffrent menu choices.
        /// </summary>
        public static void MainMenu()
        {
            Console.WriteLine("1. Check if a number is a Prime Number");
            Console.WriteLine("2. Show a list of saved Prime Numbers");
            Console.WriteLine("3. Add next Prime number from the highest number in the list");
            Console.WriteLine("4. Exit");
        }
    }
}
