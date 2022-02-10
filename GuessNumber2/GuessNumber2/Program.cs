using System;

namespace GuessNumber2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is number guessing game.");
            const int MinValue = 1;
            const int MaxValue = 100;
            const int MaxAttempts = 5;

            int userAttempts = 0;

            // Generate a random number to be guessed
            Random keygen = new Random();
            int number = keygen.Next(MinValue, MaxValue);
            Console.WriteLine($"The number to guess is {number}");
            int guess = MinValue - 1;
            while (guess != number && userAttempts < MaxAttempts)
            {
                userAttempts++;
                Console.WriteLine($"Guess attempt #{userAttempts}");
                // Prompt the user to guess the number
                Console.Write($"Enter your guess between {MinValue} and {MaxValue}: ");
                guess = int.Parse(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine("Your guess is too high");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Your guess is too low");
                }
            }

            if (guess == number)
            {
                Console.WriteLine($"Yes, the number is {number} in {userAttempts} attempts.");
            }
            else
            {
                Console.WriteLine($"You have exceeded the number of {MaxAttempts} attempts allowed.");
            }
        }
    }
}
