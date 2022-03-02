using System;

using Cpsc1012;

namespace Question03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt and read in values for hours and hourlyPayRate
            int hours,
                hourlyPayRate;
            double grossPay;

            hours = Utilities.PromptForPositiveNumber("Enter the hours worked: ");
            hourlyPayRate = Utilities.PromptForPositiveNumber("Enter the hourly pay rate: ");

            // Call CalculatePay() to return the grossPay for the employee
            grossPay = CalculatePay(hours, hourlyPayRate);

            // Display the gross pay
            Console.WriteLine($"The gross pay is {grossPay:C}");

        }

        static double CalculatePay(int hours, int payRate)
        {
            double grossPayAmount = 0;

            if (hours <= 40)
            {
                grossPayAmount = hours * payRate;
            }
            else if (hours <= 50)
            {
                grossPayAmount = 40 * payRate 
                    + 1.5 * (hours - 40) * payRate;
            }
            else
            {
                grossPayAmount = 40 * payRate 
                    + 1.5 * 10 * payRate
                    + 2.0 * (hours - 50) * payRate;
            }

            return grossPayAmount;
        }
    }
}
