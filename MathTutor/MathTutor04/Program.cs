using System;

namespace MathTutor04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exitProgram = false;
            while(exitProgram == false)
            {
                // Prompt for a menu choice
                char menuChoice = PromptForMenuChoice();
                // Process the menuChoice
                switch (menuChoice)
                {
                    case 'a':
                        {
                            //Console.WriteLine("Addition Question");
                            AskAdditionQuestion();
                        }
                        break;
                    case 's':
                        {
                            Console.WriteLine("Subtraction Question");
                        }
                        break;
                    case 'm':
                        {
                            Console.WriteLine("Multiplication Question");
                        }
                        break;
                    case 'd':
                        {
                            Console.WriteLine("Division Question");
                        }
                        break;
                    case 'x':
                        {
                            Console.WriteLine("Goodbye and thanks for playing!");
                            exitProgram = true;
                        }
                        break;
                    default:
                        Console.WriteLine("Logic error in PromptForMenuChoice");
                        break;
                }

            }
            
        }

        static void AskAdditionQuestion()
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

        static char PromptForMenuChoice()
        {
            char menuChoice = 'x';
            bool validMenuChoice = false;
            while (validMenuChoice == false)
            {
                DisplayMenu();
                menuChoice = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();
                // Check if the menuChoice is a,s,m,d, or x
                if (menuChoice == 'a' || menuChoice == 's' || menuChoice == 'm'
                    || menuChoice == 'd' || menuChoice == 'x')
                {
                    validMenuChoice = true;
                }
                else
                {
                    validMenuChoice = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid menu choice. Try again.");
                    Console.WriteLine("Press any key to continue");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            return menuChoice;
        }
        static void DisplayMenu()
        {
            Console.Write(@"
Math Tutor – Version 0.4
------------------------
a) Addition
s) Subtraction
m) Multiplication
d) Division
x) Exit Program
Enter a letter for your choice:
");
        }
    }
}
