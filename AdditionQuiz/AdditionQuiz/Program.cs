using System;

namespace AdditionQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define constants for the Minimum number and Maximum number to generate
            const int MinNumber = 1;
            const int MaxNumber = 9;
            // Create a Random object that is used to generate random numbers
            Random rand = new Random();
            // Generate two random numbers between MinNumber and MaxNumber
            int number1 = rand.Next(MinNumber, MaxNumber + 1); // Add 1 because max value is not inclusive
            int number2 = rand.Next(MinNumber, MaxNumber + 1);
            // Compute the correct answer
            int correctAnswer = number1 + number2;
            // Prompt and read in the user answer
            Console.Write($"What is {number1} + {number2} = ? ");
            int userAnswer = int.Parse(Console.ReadLine());
            // Display true if the answer is correct, otherwise, display false
            Console.WriteLine($"{number1} + {number2} = {userAnswer} is {userAnswer == correctAnswer}");

        }
    }
}
