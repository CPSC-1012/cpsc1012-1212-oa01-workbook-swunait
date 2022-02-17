using System;

namespace MathTutor03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Random object for generating random numbers
            Random rand = new Random();
            // Declare a variable to count the number of questions
            int questionCount = 0;
            // Declare a variable to count the number of correct answers
            int correctAnswerCount = 0;
            // Delcare a variable to track if user wants another question
            bool anotherQuestion = true;

            while(anotherQuestion == true)
            {
                // Declare a variable to track user attempts
                int userAttempts = 0;
                // Declare a variabel to trac if user wants to try again
                bool tryAgain = false;
                // Generate two random numbers between 1 and 99
                int num1 = rand.Next(1, 100);
                int num2 = rand.Next(1, 100);
                // Compute the correct additional answer
                int correctAnswer = num1 + num2;
                // Increment question count
                questionCount++;


                do
                {
                    // Prompt the user for the answer to the addition question
                    int userAnswer = PromptForIntegerValue($"Question #{questionCount}: What is {num1} + {num2} = ? ");
                    // Increment userAttempts
                    userAttempts++;
                    // Determine if the user answer is correct
                    if (userAnswer == correctAnswer)
                    {
                        // Answer is correct
                        Console.WriteLine($"Correct!  You got the correct answer in {userAttempts} attempts.");
                        // User does not need to try again
                        tryAgain = false;
                        // Increment correct answer count
                        correctAnswerCount++;
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

                // Ask the user if the want another question
                Console.Write("Would you like another question (y/n)?");
                anotherQuestion = char.ToLower(Console.ReadKey().KeyChar) == 'y' ? true : false;
                Console.WriteLine();
            }

            Console.WriteLine($"Thanks for playing! You answered {correctAnswerCount} out of {questionCount} questions correctly.");
              
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
