using System;

namespace GuessNumber1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is number guessing game.");
            const int minValue = 1;
            const int maxValue = 100;

            // Generate a random number to be guessed
            Random keygen = new Random();
            int number = keygen.Next(minValue, maxValue);
            int guess = minValue - 1;
            while (guess != number)
            {
                // Prompt the user to guess the number
                Console.Write($"Enter your guess between {minValue} and {maxValue}: ");
                guess = int.Parse(Console.ReadLine());
                if (guess == number)
                {
                    Console.WriteLine($"Yes, the number is {number}");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Your guess is too high");
                }
                else
                {
                    Console.WriteLine("Your guess is too low");
                }
            }

        }
    }
}
