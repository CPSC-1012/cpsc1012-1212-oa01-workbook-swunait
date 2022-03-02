using System;

namespace Cpsc1012
{
    public static class Utilities
    {
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
