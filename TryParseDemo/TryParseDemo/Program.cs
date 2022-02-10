/**
 * 
 *  Inputs: menuChoice (1,2,99,666)
 *          playerNumber
 *          PlayerPoints
 *          
 *  Outputs: playerNumber and playerPoints
 *  
 *  Algorithm:  Step 1) Delcare variables for inputs (menuChoice, playerNumber, playerPoints)
 *              Step 2) 1. Do the following:
 *                          1. Set validMenuChoiceInput to false 
 *                          2. While validMenuChoiceInput is false do the following
 *                              1. Display a menu of choices
 *                              2. Read menuChoice
 *                              3. If menuChoice is 1, 2, 99, 666 Then
 *                                  1. Set validMenuChoiceInput = true
 *                                 End If
 *                          3. Process the menuChoice as follows:
 *                              If menuChoice = 1 Then
 *                                  Set validPlayerNumber to false
 *                                  While validPlayerNumber = false do the following
 *                                      1. Prompt and read in the playerNumber
 *                                      2. If playerNumber is between 1 and 99 Then
 *                                            validPlayerNumber true
 *                                          End If
 *                               Else If menuChoice = 2 Then
 *                                  Set  validPlayerPoints to false
 *                                  While validPlayerPoitns = false do the following
 *                                      1. Prompt and read the playerPoints
 *                                      2. If playerPoints >= 0 Then
 *                                          validPlayerPoints = true
 *                                         End If
 *                               Else If menuChoice = 99 Then
 *                                  Display playerNumber and playerPoints
 *                               Else if menuChoice = 666 Then
 *                                  Display Goodbye message
 *                               Else
 *                                  Display invalid menuChoice
 *                               End If
 *                         
 *                          While menuChoice != 666
 * */
using System;

namespace TryParseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program demonstrates how to use TryParse to valid for numeric input.");

            // Prompt for a valid hockey player number between 1 and 99
            // Repeat until a valid hockey player number is entered
            int hockeyPlayerNumber = 0;
            int hockeyPlayerPoints = 0;
            int menuChoice = 666;
            const int ExitProgramChoice = 666;

            do
            {
                bool validMenuChoiceInput = false;
                while ( validMenuChoiceInput == false)
                {
                    Console.WriteLine(@"
1. Enter player number (between 1 and 99)
2. Enter player points (0 or more)
99. Display player info (number and points)
666. Exit program.
");
                    Console.Write("Enter your choice >: ");
                    validMenuChoiceInput = int.TryParse(Console.ReadLine(), out menuChoice);
                    if (validMenuChoiceInput 
                        && (menuChoice == 1 || menuChoice == 2 || 
                            menuChoice == 99 || menuChoice == 666) ) 
                    {
                        validMenuChoiceInput = true;
                    }
                }

                switch (menuChoice)
                {
                    case 1: // enter player number
                        {
                            //Console.WriteLine("Enter player number");
                            bool validPlayerNumber = false;
                            while (validPlayerNumber == false)
                            {
                                Console.Write("Enter the hockey player number (1-99): ");
                                validPlayerNumber = int.TryParse(Console.ReadLine(), out hockeyPlayerNumber);
                                if (validPlayerNumber && 
                                        (hockeyPlayerNumber >= 1 && hockeyPlayerNumber <= 99))
                                {
                                    validPlayerNumber = true;
                                }
                                else
                                {
                                    validPlayerNumber = false;
                                    Console.WriteLine($"The hockey player must be between 1 and 99.");
                                }
                            }                                                                          

                        }
                        break;
                    case 2: // enter player points
                        {
                            //Console.WriteLine("Enter player points");
                            bool validPlayerPoints = false;
                            while (validPlayerPoints == false)
                            {
                                Console.Write("Enter the hockey player points: ");
                                validPlayerPoints = int.TryParse(Console.ReadLine(), out hockeyPlayerPoints);
                                if (validPlayerPoints && hockeyPlayerPoints >= 0)
                                {
                                    validPlayerPoints = true;
                                }
                                else
                                {
                                    validPlayerPoints = false;
                                    Console.WriteLine($"The hockey player points must be a positive number.");
                                }
                            }
                        }
                        break;
                    case 99:    // display player number and points
                        {
                            //Console.WriteLine("Display player number and points");
                            // Display the hockey player number
                            Console.WriteLine($"Player number is {hockeyPlayerNumber} and points is {hockeyPlayerPoints}");
                        }
                        break;
                    case 666:   // exit program
                        {
                            Console.WriteLine("Good-bye and come back soon.");
                        }
                        break;
                    default:    // invalid menu choice
                        Console.WriteLine("Error! Invalid input value.");
                        break;

                }
                

            } while (menuChoice != ExitProgramChoice); 
           

            
        }
    }
}
