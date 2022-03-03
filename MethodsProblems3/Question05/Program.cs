using System;
using Cpsc1012;

namespace Question05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char menuChoice = 'X';
            double totalGrossIncome = 0;
            bool endProgram = false;

            while (endProgram == false)
            {
                // Display a menu of choices
                DisplayMenuChoices();
                menuChoice = Console.ReadKey().KeyChar;
                menuChoice = char.ToUpper(menuChoice);
                Console.WriteLine();

                // Process the menu choice as follows:
                // A - Calculate Airport Amount
                // R - Calculate Regular Fare Amount
                // F - Calculate Flat Rate Amount
                // X - Exit program
                switch (menuChoice)
                {
                    case 'A':
                        totalGrossIncome += CalculateAirportAmount();
                        break;
                    case 'R':
                        totalGrossIncome += CalcualteRegularFareAmount();
                        break;
                    case 'F':
                        totalGrossIncome += CalculateFlatRateAmount();
                        break;
                    case 'X':
                        endProgram = true;
                        break;
                    default:
                        Console.WriteLine("Invalid menu choice.");
                        break;
                }
            }

            // Display the total gross income
            Console.WriteLine($"The daily total gross income is {totalGrossIncome:C}");

        }

        static double CalculateAirportAmount()
        {
            double airportAmount = 0;
            const double FlatRateAirportCharge = 25.00;
            double tipAmount = Utilities.PromptForDoublePositiveOrZero("Enter tip amount: ");
            airportAmount = FlatRateAirportCharge + tipAmount;
            return airportAmount;
        }

        static double CalcualteRegularFareAmount()
        {
            double regularFareAmount = 0;
            const double ChargePerKilometer = 1.10;
            const double ChargePerMinute = 0.20;

            double distance = Utilities.PromptForDoublePositiveOrZero("Enter distance travelled in km: ");
            double time = Utilities.PromptForDoublePositiveOrZero("Enter time traveled in minutes: ");
            double tipAmount = Utilities.PromptForDoublePositiveOrZero("Enter tip amount: ");
            regularFareAmount = distance * ChargePerKilometer + time * ChargePerMinute + tipAmount;

            return regularFareAmount;
        }

        static double CalculateFlatRateAmount()
        {
            double flatRateAmount = 0;

            double flatRate = Utilities.PromptForDoublePositiveOrZero("Enter flat rate amount: ");
            double tipAmount = Utilities.PromptForDoublePositiveOrZero("Enter tip amount: ");
            flatRateAmount = flatRate + tipAmount;

            return flatRateAmount;
        }

        static void DisplayMenuChoices()
        {
            Console.WriteLine(@"
Enter a leter for your choice
A: Airport Trip
R: Regular fare
F: Flat rate
X: Exit program
Your choice: 
");
        }

    }
}
