using System;

namespace Squares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number; // Loop control variable
            Console.WriteLine($"{"Number",-10} {"Number Squared",15}");
            Console.WriteLine($"-------------------------");
            for (int number = 1; number <= 10; number++)
            {
                Console.WriteLine($"{number,-10} {number * number,15}");
            }

        }
    }
}
