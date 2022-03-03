using System;

namespace Cpsc1012
{
    public static class Utilities
    {
        static public double PromptForDoublePositiveOrZero(string message)
        {
            double doubleValue = 0;
            bool validNumber = false;
            while (validNumber == false)
            {
                Console.Write(message);
                if (double.TryParse(Console.ReadLine(), out doubleValue))
                {
                    if (doubleValue >= 0)
                    {
                        validNumber = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input value! Number must be zero or greater");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input value! Value must a numeric number.");
                }
            }
            return doubleValue;
        }
        static public int PromptForPositiveNumber(string message)
        {
            int number = 0;
            bool validNumber = false;
            while (validNumber == false)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number > 0)
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
