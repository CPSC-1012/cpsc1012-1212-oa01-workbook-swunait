using System;

namespace SaleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for the price, tax, and total.
            double price,
                    tax,
                    total;
            // Assign values to the varaibles for price, tax, and total
            price = 29.75;
            tax = 1.76;
            total = 31.51;

            // Write to the screen the price, tax, and total.
            Console.WriteLine($"The price of the item is {price:C}");
            Console.WriteLine($"The tax is {tax:C}");
            Console.WriteLine($"The total is {total:C}");

        }
    }
}
