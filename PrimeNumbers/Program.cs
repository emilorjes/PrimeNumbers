using PrimeNumber.Controllers;

namespace PrimeNumber
{
    internal static class Program
    {
        /// <summary>
        /// The main method that start the program.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            MainMenuController.MainMenu();
        }

        // I have used the StopWatch class to test diffrent methods and checked wich one is faster. Example: .MAX() or my own method.
        // All classes and methods are static because a dont create any objects.
        // I have chosen the data structure List<> so i can add how many elements i want, so i can check if list already contains an element and print out element easy.
        // Because the program is not that big a List<> works fine in this case. If the program would hav been bigger, a faster datastructure lika HashSet/ HashMap / Dictonary  would be prefered.
    }
}
