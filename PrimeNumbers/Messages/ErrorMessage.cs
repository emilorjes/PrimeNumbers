using System;

namespace PrimeNumber.Messages
{
    /// <summary>
    /// A class the contains diffrent error messages.
    /// </summary>
    public static class ErrorMessage
    {
        public static void InputNeedsToMatchOneOfTheMenuChoice()
        {
            Console.WriteLine("The input needs to match one of the menuchoice (1-4)");
        }

        public static void IsNotANumber(string input)
        {
            Console.WriteLine($"The input [{input}] Is NOT a number");
        }

        public static void ListIsEmpty()
        {
            Console.WriteLine("The list is empty");
        }

        public static void NeedsToBeGreaterThanZero()
        {
            Console.WriteLine("The number cant be less or equal to zero");
        }

        public static void NeedsToHaveAnInput()
        {
            Console.WriteLine("The input cant be empty, you need to have an input!");
        }
        public static void NeitherPrimeNorComposite(int number)
        {
            Console.WriteLine($"The number [{number}] is either Prime or Composite");
        }

        public static void WrongInput()
        {
            Console.WriteLine("Wrong input!");
        }
    }
}
