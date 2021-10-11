using System;

namespace PrimeNumber.Messages
{
    /// <summary>
    /// A class that contains diffrent info messages.
    /// </summary>
    public static class InfoMessage
    {
        public static void EnterNumberOrGoBack()
        {
            Console.Write("Enter a number (Or B to go back): ");
        }

        public static void HighestPrimeNumber(int number)
        {
            Console.WriteLine($"Highets Prime number in list is {number}");
        }

        public static void IsCompositeNumber(int number)
        {
            Console.WriteLine($"The number [{number}] is a Composite number");
        }

        public static void IsPrimeNumberAndAddedToList(int number)
        {
            Console.WriteLine($"The number [{number}] is a Prime number (ADDED to list)");
        }

        public static void IsPrimeNumberButAlredyAddedToList(int number)
        {
            Console.WriteLine($"The number [{number}] is a Prime number (ALREDY added to list)");
        }

        public static void ListOfPrimeNumbers()
        {
            Console.WriteLine("Numbered list of saved Prime numbers: ");
        }

        public static void NextPrimeNumberIs(int number)
        {
            Console.WriteLine($"The next Prime number is [{number}] (added to list)");
        }

        public static void TheListWasEmptySoFirstPrimeNumberWasAdded()
        {
            Console.WriteLine("The list was empty so number [2] that is the first prime number was added to the list.");
        }
    }
}
