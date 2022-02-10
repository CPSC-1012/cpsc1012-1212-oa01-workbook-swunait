using System;

namespace UserSquares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number; // Loop control variable
            int maxValue; // Maximum value to display
            Console.WriteLine("I will display a table of numbers and their squares.");
            Console.Write("How high should I go? ");
            maxValue = int.Parse(Console.ReadLine());

            Console.WriteLine($"{"Number",-10} {"Number Squared",15}");
            Console.WriteLine($"-------------------------");
            for (number = 1; number <= maxValue; number++)
            {
                Console.WriteLine($"{number,-10} {number * number,15}");
            }

        }
    }
}
