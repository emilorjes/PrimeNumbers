using System;

namespace PrimeNumber.Helpers
{
    public static class PrimeNumberHelper
    {
        /// <summary>
        /// A method that checks if the number that is sent in as an in paramterter is a prime number or not. Parts of the method is from the algorithm Sieve of Eratosthenes.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Returns true directly if number is equal to 2 (first prime number). Otherwise return true if number IS a prime number.
        /// Returns false directly if number is less tha 2 or if number modolu 2 is equal to 0. Otherwise returns false if number is NOT a prime number.</returns>
        public static bool IsPrimeNumber(int number)
        {
            if (number < 2) return false; // If number is less than 2 return false (1 is either a prime number or a composite number and prime number is positive numbers)
            if (number == 2) return true; // The number 2 is the first prime number and the only even prime number. Returns true.
            if (number % 2 == 0) return false; // Checks if the number is even by checking if the number modulo 2 have a rest of 0, if thats true, it is an even number (the only even prime number is the number 2). Returns false.

            // After we have checked the three statements above and none of them are "true", we only have odd number left.
            // Because whe have already checked the first prime number 2, the for loop can start from number 3.
            // Then we use the Math.Sqrt to get the square root from the number (exampel: Math.Sqrt(81) = 9).
            // The i is incremented by 2 so the for loop only check odd number because it starts at 3 så every number after that ar odd example: 3, 5, 7, 9, 11, 13.........
            // To investigate whether a number is a prime number we can try to divide each prime numbers that are smaller than the square root of the given number and check the rest value.
            // If the square root of the given number is divided by one of the prime numbers and get a rest of 0 that means that the given number is NOT a prime number!
            // (exampel: Math.Sqrt(81) = 9) Prime numbers upp to 9 = 2, 3, 5, 7. 9 can be devided by 3 so that means that 81 is NOT a prime number.
            // If the square root of the given number is divided by one of the prime numbers and get a rest that is NOT 0, that means that the given number IS a prime number!
            // (exampel: Math.Sqrt(79) = 8.88819441732) Prime numbers upp to 8.9 = 2, 3, 5, 7. 8.9 cant be devided by any of the prime numbers and get a rest of 0 so that means that 79 IS a prime number.
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) // If the number modolu i has a rest of 0 than the number is NOT a prime number. Returns false.
                {
                    return false;
                }
            }

            return true; // If the number modolu i does NOT have a rest of 0 than the number is a prime number. Return true.
        }
    }
}
