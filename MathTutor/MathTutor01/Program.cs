using System;

namespace MathTutor01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Random object for generating random numbers
            Random rand = new Random();
            // Generate two random numbers between 1 and 99
            int num1 = rand.Next(1, 100);
            int num2 = rand.Next(1, 100); 
            // Compute the correct additional answer
            int correctAnswer = num1 + num2;
            // Prompt the user for the answer to the addition question
            int userAnswer = PromptForIntegerValue($"What is {num1} + {num2} = ? ");
            // Determine if the user answer is correct
            if (userAnswer == correctAnswer)
            {
                // Correct Answer
                Console.WriteLine($"Correct! {num1} + {num2} = {correctAnswer}");
            }
            else
            {
                // Incorrect Answer
                Console.WriteLine($"Incorrect! The correct answer is {correctAnswer}.");
            }
        }

        static int PromptForIntegerValue(string message)
        {
            int integerValue = 0;

            // Prompt the user using the message parameter variable
            Console.Write(message);
            while (int.TryParse(Console.ReadLine(), out integerValue) == false)
            {
                // Input value is not an integer
                Console.WriteLine("Invalid input! You must enter an integer value for the answer.");
                Console.Write(message);
            }

            return integerValue;
        }
    }
}
