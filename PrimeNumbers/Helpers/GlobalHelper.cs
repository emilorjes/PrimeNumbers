using System;
using System.Collections.Generic;

namespace PrimeNumber.Helpers
{
    public static class GlobalHelper
    {
        /// <summary>
        /// This method gets the highest number in a list with help of an for loop.
        /// The built-in method Max() could have been used instead of this method, but this method is faster.
        /// </summary>
        /// <param name="intList"></param>
        /// <returns>Returns the highest number from the list</returns>
        public static int GetHighestNumberInIntList(List<int> intList)
        {
            int highestNumber = intList[0]; // The highestNumber is set to the first element in the list because i want to start to compare the first element.

            for (int i = 0; i < intList.Count; i++) // The loop loops as long as the count of the list. The hole list needs to be checked to find the highest number.
            {
                if (intList[i] > highestNumber) // If the current index (element) in list is greater than the highest number the current index (element) is set to highestNumber.
                {
                    highestNumber = intList[i];
                }
            }

            return highestNumber; //If the current index (element) is NOT greater than highestNumber (not greater than itself you could say) it returns the highestNumber.
        }

        /// <summary>
        /// With help of a foreach loop this method prints out a numbered list that starts from 1 and is incremented with 1 for every element that exist in tha list that is send as in parameter.
        /// </summary>
        /// <param name="intList"></param>
        public static void NumberedIntList(List<int> intList)
        {
            int i = 1;

            foreach (int number in intList)
            {
                Console.WriteLine($"{i}. [{number}]");
                i++;
            }
        }
        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //
        // I tried to use this method i created instead of the inbuilt method Contains() but this method was slower than that method i created so i went for the Contains() method insteed.
        // I left this method commented out, in a normal case i would have deleted this unused method!
        //
        //public static bool CheckIfListContainsElementAlredy(List<int> intList, int number)
        //{
        //    for (int i = 0; i < intList.Count; i++)
        //    {
        //        if(intList[i] == number)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //
        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    }
}
