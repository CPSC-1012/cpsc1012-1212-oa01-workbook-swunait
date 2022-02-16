using System;

namespace CupConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cups; // To hold the number of cups.
            double ounces; // To hold the number of ounces.
                           // Get the number of cups.
            cups = GetCups();
            // Convert the cups to fluid ounces
            ounces = CupsToOunces(cups);
            // Display the results.
            DisplayResults(cups, ounces);
        }

        // this method prompts the user to enter the number of cups.
        static double GetCups()
        {
            double numCups; // To hold cups
                            // Get the number of cups from the user.
            Console.WriteLine("This program converts measurements in cups to fluid ounces.");
            Console.WriteLine("For your reference the formula is:");
            Console.WriteLine("\t1 cup = 8 fluid ounces.");
            Console.WriteLine("\nEnter the number of cups.");
            numCups = double.Parse(Console.ReadLine());
            return numCups;
        }

        // This method converts a number of cups to fluid ounces, 
        // using the formula
        // 1 cup = 8 ounces
        static double CupsToOunces(double numCups)
        {
            return numCups * 8.0;
        }
        static void DisplayResults(double cups, double ounces)
        {
            // Display the number of cups
            Console.WriteLine($"{cups} cups equals {ounces} fluid ounces.");
        }

    }
}
