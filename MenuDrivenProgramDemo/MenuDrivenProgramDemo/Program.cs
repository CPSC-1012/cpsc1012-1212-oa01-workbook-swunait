using System;

namespace MenuDrivenProgramDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuChoice;
            int number = 0;
            double points = 0.0;
            do
            {
                Console.WriteLine("Hockey Player Stats");
                Console.WriteLine("-------------------");
                Console.WriteLine("1. Enter player number");
                Console.WriteLine("2. Enter player points");
                Console.WriteLine("99. Display player info (number and points)");
                Console.WriteLine("666. Exit Program");
                Console.Write("Enter your choice >: ");
                if (int.TryParse(Console.ReadLine(), out menuChoice))
                {
                    switch (menuChoice)
                    {
                        case 1:
                            bool validNumber = true;
                            Console.Write("Player Number: ");
                            validNumber = int.TryParse(Console.ReadLine(), out number);
                            Console.WriteLine();
                            break;
                        case 2:
                            bool validPoints = true;
                            Console.Write("Player Points: ");
                            validPoints = double.TryParse(Console.ReadLine(), out points);
                            Console.WriteLine();
                            break;
                        case 99:
                            Console.WriteLine($"Player {number} has {points:f2} points.\n");
                            break;
                        case 666:
                            Console.WriteLine("Goodbye");
                            break;
                        default:
                            Console.WriteLine("Invalid Input Try Again\n");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input value! Value must be a numeric integer.");
                }
                
            } while (menuChoice != 666);
        }
    }
}
