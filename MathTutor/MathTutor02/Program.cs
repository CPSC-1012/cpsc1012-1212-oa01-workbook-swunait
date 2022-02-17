using System;

namespace MathTutor02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a variable to track user attempts
            int userAttempts = 0;
            // Declare a variabel to trac if user wants to try again
            bool tryAgain = false;
            // Create a Random object for generating random numbers
            Random rand = new Random();
            // Generate two random numbers between 1 and 99
            int num1 = rand.Next(1, 100);
            int num2 = rand.Next(1, 100);
            // Compute the correct additional answer
            int correctAnswer = num1 + num2;


            do
            {
                // Prompt the user for the answer to the addition question
                int userAnswer = PromptForIntegerValue($"What is {num1} + {num2} = ? ");
                // Increment userAttempts
                userAttempts++;
                // Determine if the user answer is correct
                if (userAnswer == correctAnswer)
                {
                    // Answer is correct
                    Console.WriteLine($"Correct!  You got the correct answer in {userAttempts} attempts.");
                    // User does not need to try again
                    tryAgain = false;
                }
                else
                {
                    // Answer is incorrect
                    Console.Write("Incorrect! Would you like to try again (y/n)?");
                    tryAgain = char.ToLower(Console.ReadKey().KeyChar) == 'y' ? true : false;
                    Console.WriteLine();
                    if (tryAgain == false)
                    {
                        Console.WriteLine($"The correct answer is {correctAnswer}.");
                    }
                }

            } while (tryAgain == true); // (tryAgain)           

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
