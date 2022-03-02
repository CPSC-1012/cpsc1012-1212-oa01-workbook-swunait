using System;

using Cpsc1012;

namespace Question01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt and read in pennies, nickels, dimes, quarters, loonies, twoonies
            int pennies,
                 nickels,
                 dimes,
                 quarters,
                 loonies,
                 twoonies;
            double totalAmount;

            pennies = Utilities.PromptForPositiveNumber("Enter the number of pennies: ");
            nickels = Utilities.PromptForPositiveNumber("Enter the number of nickels: ");
            dimes = Utilities.PromptForPositiveNumber("Enter the number of dimes: ");
            quarters = Utilities.PromptForPositiveNumber("Enter the number of quarters: ");
            loonies = Utilities.PromptForPositiveNumber("Enter the number of loonies: ");
            twoonies = Utilities.PromptForPositiveNumber("Enter the number of twoonies: ");

            // Call GetTotal method to return the total in dollars and cents for 
            // all the coins combines
            totalAmount = GetTotal(pennies, nickels, dimes, quarters, loonies, twoonies);

            // Display the total of all the coins
            Console.WriteLine($"The total amount is {totalAmount:C}");
        }

        static double GetTotal(
            int pennies, 
            int nickels, 
            int dimes,
            int quarters,
            int loonies,
            int twoonies)
        {
            double totalAmount = 0;

            totalAmount = twoonies * 2
                + loonies
                + quarters * 0.25
                + dimes * 0.10
                + nickels * 0.05
                + pennies * 0.01;

            return totalAmount;
        }

    }
}
