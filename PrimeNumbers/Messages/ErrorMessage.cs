using System;

namespace PrimeNumber.Messages
{
    /// <summary>
    /// A class the contains diffrent error messages.
    /// </summary>
    public static class ErrorMessage
    {
        public static void BiggestNumberForThisProgam()
        {
            Console.WriteLine($"You cant add any more prime numbers because {int.MaxValue} is the biggest number you can check in this program.");
        }

        public static void InputNeedsToMatchOneOfTheMenuChoice()
        {
            Console.WriteLine("The input needs to match one of the menuchoice (1-4)");
        }
        public static void IsEitherToBigOrNotANumber(string input)
        {
            Console.WriteLine($"The input [{input}] is either to big or is not a number. ( Biggest number for this program is: {int.MaxValue}) ");
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