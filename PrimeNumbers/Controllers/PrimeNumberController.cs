using PrimeNumber.Helpers;
using PrimeNumber.Messages;
using System;
using System.Collections.Generic;

namespace PrimeNumber.Controllers
{
    public static class PrimeNumberController
    {
        /// <summary>
        /// List of int that holds prime numbers.
        /// I have chosen the data structure List<> so i can add how many elements i want, so i can check if list already contains an element and print out element easy.
        /// Because the program is not that big a List works fine in this case. If the program would hav been bigger, a faster datastructure lika HashSet/ HashMap / Dictonary  would be prefered.
        /// </summary>
        private static readonly List<int> primeNumberList = new();

        /// <summary>
        /// A method that checks if input is an prime number or not.
        /// Diffrent states are checked depending on what the input is.
        /// If the input is an prime number it is added to primeNumberLIst (if the element dont already exists in the list).
        /// </summary>
        public static void CheckIfNumberIsPrime()
        {
            while (true)
            {
                Console.Clear();
                InfoMessage.EnterNumberOrGoBack(); // Display enter number or go back.
                string input = Console.ReadLine().ToLower(); // Uses the ToLower so both b and B can be used when the user want to go back.

                if (int.TryParse(input, out int number)) // Tries to convert the input to an int, if succes return true, otherwise return false.
                {
                    if (number <= 0) // Checks if number is less or equal to 0, prints error message. Prime number is positive numbers.
                    {
                        ErrorMessage.NeedsToBeGreaterThanZero();
                    }
                    else if (number == 1) //Checks if number is equal to zero, prints error message. The number 1 is either a prime number or coposite number.
                    {
                        ErrorMessage.NeitherPrimeNorComposite(number);
                    }
                    else
                    {
                        bool isPrime = PrimeNumberHelper.IsPrimeNumber(number); // The bool that is returned from the IsPrimeNumber is saved in isPrime.
                        if (isPrime) // If isPrime is true that means that the number is an prime number.
                        {
                            if (primeNumberList.Contains(number))// Checks if the primeNumberList alredy contains the given number with the in-built method Contains(), prints info message.
                            {
                                InfoMessage.IsPrimeNumberButAlredyAddedToList(number);
                            }
                            else
                            {
                                primeNumberList.Add(number); // Given prime number is added to primeNumberList, prints info message.
                                InfoMessage.IsPrimeNumberAndAddedToList(number);
                            }
                        }
                        else
                        {
                            InfoMessage.IsCompositeNumber(number); // If isPrime is false it means that the number is a composite number because 0, and 1 is already cheked, prints info message.
                        }
                    }
                }
                else if (string.IsNullOrWhiteSpace(input)) // If input doesent have any input or only have whitespace, prints error message.
                {
                    ErrorMessage.NeedsToHaveAnInput();
                }
                else if (input == "b") // If input is b or B than the program breaks out of the loop.
                {
                    break;
                }
                else // Else, prints error message.
                {
                    ErrorMessage.IsEitherToBigOrNotANumber(input);
                }
                Console.ReadLine();
            }
        }

        /// <summary>
        /// A method that gets the next prime number from the highest prime number in primeNumberList.
        /// </summary>
        public static void GetNextPrimeNumberFromHighestNumberInList()
        {
            Console.Clear();

            int highestNumber;
            if (primeNumberList.Count == 0) // Check if the primNumberList is empty, sets the highestNumber to 1 because the list is empty and we want to start at 1.
            {
                highestNumber = 1;
            }
            else // The highestNumber is set with the GetHighestNumberInIntList() method and prints a info message.
            {
                highestNumber = GlobalHelper.GetHighestNumberInIntList(primeNumberList);
                InfoMessage.HighestPrimeNumber(highestNumber);
            }

            int nextNumberToCheckIfIsPrime = highestNumber + 1; // The nextNumberToCheckIfIsPrime is set to the number that comes after the highest number.
            bool keepSearchingForPrime = true;
            while (keepSearchingForPrime) // While the keepSearchingForPrime bool is true the while loop will loop.
            {
                if (highestNumber == int.MaxValue) // If highestNumber is equal to int.MaxValue, print error message and break loop.
                {
                    ErrorMessage.BiggestNumberForThisProgam();
                    break;
                }

                bool isPrime = PrimeNumberHelper.IsPrimeNumber(nextNumberToCheckIfIsPrime); // The isPrime bool is set with the isPrimeNumber() method that checks if the nextNumberToCheckIfIsPrime is a prime.
                if (isPrime) // If isPrime is true diffrent states are checked.
                {
                    primeNumberList.Add(nextNumberToCheckIfIsPrime); // If isPrime is true nextNumberToCheckIfIsPrime is added to primeNumberList.
                    if (highestNumber == 1) // If highestNumber is equal to 1, print info message.
                    {
                        InfoMessage.TheListWasEmptySoFirstPrimeNumberWasAdded();
                    }
                    else // If highestNumber is greater than 1, print info message. !!!Because the highestNumber in this case should never be less than 0 i can use only else here, otherwise i shuld have used else if!!!
                    {
                        InfoMessage.NextPrimeNumberIs(nextNumberToCheckIfIsPrime);
                    }
                    keepSearchingForPrime = false; // keepSearchingForPrime is set to false and the loop ends.
                }
                else // If isPrime is false the nextNumberToCheckIfIsPrime is incrementen by 1 and the keepSearchingForPrime bool is still true so the loop loops again.
                {
                    nextNumberToCheckIfIsPrime++;
                }
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Prints out a list of prime numbers depending on if the primeNumberList is empty or not.
        /// </summary>
        public static void ListOfPrimeNumbers()
        {
            Console.Clear();
            if (primeNumberList.Count == 0) // If primeNumberList is empty, prints error message.
            {
                ErrorMessage.ListIsEmpty();
            }
            else // If primeNumberList is NOT empty a info message and a numbered list of the prime numbers in primeNumberList is printed out.
            {
                InfoMessage.ListOfPrimeNumbers();
                GlobalHelper.NumberedIntList(primeNumberList);
            }
            Console.ReadLine();
        }
    }
}