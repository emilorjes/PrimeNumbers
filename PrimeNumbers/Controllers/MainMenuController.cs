using PrimeNumber.Messages;
using PrimeNumber.Views;
using System;

namespace PrimeNumber.Controllers
{
    public static class MainMenuController
    {
        /// <summary>
        /// A method that controls the main menu.
        /// If the input matches one of the four cases a specific method is executed.
        /// </summary>
        public static void MainMenu()
        {
            while (true)
            {
                Console.Clear();
                MainMenuView.MainMenu(); // Display the main menu.
                string input = Console.ReadLine(); // Reads string input.
                if (int.TryParse(input, out int menuChoice)) // Tries to convert the input to an int, if succes return true, otherwise return false.
                {
                    switch (menuChoice)
                    {
                        case 1: // If input is 1 call the CheckIfNumberIsPrime() method.
                            PrimeNumberController.CheckIfNumberIsPrime();
                            break;

                        case 2:// If input is 2 call the ListOfPrimeNumbers() method.
                            PrimeNumberController.ListOfPrimeNumbers();
                            break;

                        case 3:// If input is 3 call the GetNextPrimeNumber() method.
                            PrimeNumberController.GetNextPrimeNumberFromHighestNumberInList();
                            break;

                        case 4:// If input is 4 call the  Environment.Exit() method and exit program.
                            Environment.Exit(0);
                            break;

                        default: // If input is an int but not betwwen 1-4, print out error message.
                            ErrorMessage.InputNeedsToMatchOneOfTheMenuChoice();
                            Console.ReadLine();
                            break;
                    }
                }
                else // If TryParse is false, print out error message.
                {
                    ErrorMessage.WrongInput();
                    Console.ReadLine();
                }
            }
        }
    }
}
