using System;

namespace TotalSales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days; // The number of days
            double sales; // A day's sales figure
            double totalSales; // Accumulator
                               // Get the number of days.
            Console.Write("For how many days do you have sales figures for? ");
            days = int.Parse(Console.ReadLine());
            // Set the accumulator to 0.
            totalSales = 0;
            // Get the sales figures and calculate a running total
            for (int count = 1; count <= days; count++)
            {
                Console.Write($"Enter the sales figure for day #{count}: ");
                sales = double.Parse(Console.ReadLine());
                totalSales += sales;
            }
            // Round totalSales to 2 decimal places
            totalSales = Math.Round(totalSales, 2);
            // Display the totalSales
            Console.WriteLine($"The total sales for {days} days is {totalSales:C}");

        }
    }
}
