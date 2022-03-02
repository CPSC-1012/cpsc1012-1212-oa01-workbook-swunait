using System;

namespace Average1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            double sum = 0;
            const int SentinelValue = 999;
            bool sentinelValueEntered = false;
            double average = 0;

            while (sentinelValueEntered == false)
            {
                int number = PromptForPositiveNumber("Enter a number (999 to end): ");
                if (number != SentinelValue)
                {
                    count++;
                    sum += number;
                }
                else
                {
                    sentinelValueEntered = true;
                }
            }
            if (count > 0)
            {
                average = sum / count;
                Console.WriteLine($"Average is inputs is {average:F1}");
            }
            


        }

        static int PromptForPositiveNumber(string message)
        {
            int number = 0;
            bool validNumber = false;
            while (validNumber == false)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number > 0 )
                    {
                        validNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("Error! Number must be a positive non-zero number");
                    }
                }
                else
                {
                    Console.WriteLine("Error! Input must be integer number");
                }
            }
            return number;
        }
    }
}
