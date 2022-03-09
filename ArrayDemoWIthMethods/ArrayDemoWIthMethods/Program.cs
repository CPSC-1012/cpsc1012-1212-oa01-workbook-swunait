using System;
using System.IO;    // for StreamWriter

namespace ArrayDemoWIthMethods
{
    internal class Program
    {
        static void DisplayMainMenu()
        {
            Console.WriteLine(@"
*** Lotto Quick Pick System ****
1) Generate lotto quick picks
2) Read lotto quick picks from a file
3) Quit program
Your choice: ");
        }

        static void GenerateLottoQuickPicks()
        {
            // Prompt the user for the number of quick picks
            int numberOfQuickPicks = 0;
            Console.Write("How many quick picks do you want: ");
            numberOfQuickPicks = int.Parse(Console.ReadLine());

            // TODO: Ask the the user if they want to write the numbers to a file.
            // If user answers yes then prompt for a filename and
            // write the generate numbers to the filename.
            Console.Write("Would you like to write the numbers to a file? [y/n]: ");
            bool writeToFile = char.ToLower(Console.ReadKey().KeyChar) == 'y' ? true : false;
            Console.WriteLine();
            if (writeToFile)
            {
                // Ask the user for the file name
                Console.Write(@"Enter the file path to write to (ex. D:\temp\mar09.txt): ");
                string dataExportFilePath = Console.ReadLine();
                try
                {
                    StreamWriter writer = new StreamWriter(dataExportFilePath);
                    for (int counter = 1; counter <= numberOfQuickPicks; counter++)
                    {
                        int[] lottoNumberArray = GenerateNumbers(1, 50, 7);
                        int index = 0;
                        foreach (int lottoNumber in lottoNumberArray)
                        {
                            writer.Write(lottoNumber);
                            index++;
                            if (index < lottoNumberArray.Length)
                            {
                                writer.Write(",");
                            }
                        }
                        writer.WriteLine();
                    }
                    writer.Close();
                    Console.WriteLine($"Successfully wrote numbers to {dataExportFilePath}");
                }
                catch (Exception ex)
                {
                    // Report the exception to the user
                    Console.WriteLine($"Error writing to file to exception?: {ex.Message}");
                }
            }
            else
            {
                // Generate the quick picks
                for (int counter = 1; counter <= numberOfQuickPicks; counter++)
                {
                    // TODO: For each quick pick generate 7 random numbers between 1 and 50
                    // by calling the GenerateNumbers methods
                    // and write the generated numbers to a text file
                    int[] lottoNumberArray = GenerateNumbers(1, 50, 7);
                    // Display all the numbers generated
                    Console.Write($"Quick Pick #{counter}: ");
                    DisplayNumbers(lottoNumberArray);

                }
            }
        }

        static void ReadLottoQuicksFromFile()
        {
            // Ask the user for the file path
            Console.Write("Enter the location of the data file: ");
            string dataImportFilePath = Console.ReadLine();
            // Read from the file path one line at a time and write the screen each line that is read
            try
            {
                StreamReader reader = new StreamReader(dataImportFilePath);
                while (reader.EndOfStream == false)
                {
                    // Read the current line and move the input cursor to the next line
                    string currentLine = reader.ReadLine();
                    // Print the current to the screen
                    Console.WriteLine(currentLine);
                }
                reader.Close();
            } 
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading from file {dataImportFilePath} with exception {ex.Message}");
            }

        }

        static void Main(string[] args)
        {
            // TODO: Modify the program to implement a menu-driven system where the user can:
            // 1) Generate lotto quick picks
            // 2) Read lotto quick picks from a file
            // 3) Quit program
            int menuChoice = 0;
            const int QuitProgramChoice = 3;

            while (menuChoice != QuitProgramChoice)
            {
                DisplayMainMenu();
                menuChoice = int.Parse(Console.ReadLine());
                switch (menuChoice)
                {
                    case 1: // generate lotto quick picks 
                        {
                            // Call method to generate lotto quick picks
                            GenerateLottoQuickPicks();
                        }
                        break;
                    case 2: // read lotto quick picks from file
                        {
                            // Call method to read lotto quick picks from a file
                            ReadLottoQuicksFromFile();
                        }
                        break;
                    case 3:
                        // do nothing
                        break;
                    default:
                        Console.WriteLine("Invalid menu choice. Try again.");
                        break;
                }
            }

        }

        static int[] GenerateNumbers(
            int minValue,
            int maxValue,
            int numberCount)
        {
            // Declare and create a new int array of size numberCount
            int[] numberArray = new int[numberCount];
            // Create and create a new Random object that we can use to generate random numbers
            Random rand = new Random();
            // Assign a random number between minValue and maxValue for each
            // element in the array
            for (int index = 0; index < numberCount; )
            {
                // Generate a random number between minValue and maxValue
                // If the random number is not a duplicate number,
                // then add the random number to the array, otherwise,
                // generate another random number
                // Hint: You can call the IsDuplicateNumber method
                //numberArray[index] = rand.Next(minValue, maxValue + 1);
                int randomNumber = rand.Next(minValue, maxValue + 1);
                if (IsDuplicateNumber(randomNumber, numberArray) == false)
                {
                    numberArray[index] = randomNumber;
                    index++;
                }
            }
            // Sort the numberArray ascending from smallest to largest
            // Hint: The Array class has a static class-level method for sorting
            Array.Sort(numberArray);

            return numberArray;
        }

        static bool IsDuplicateNumber(int number, int[] numberArray)
        {
            bool isDuplicate = false;

            // Set isDuplicate to true if number is in numberArray
            for (int index = 0; index < numberArray.Length; index++)
            {
                if (numberArray[index] == number)
                {
                    isDuplicate = true;
                    index = numberArray.Length; // graceful technique to exit loop
                }
            }

            return isDuplicate;
        }

        static void DisplayNumbers(int[] numberArray)
        {
            // Display each element in numberArray,
            // where each element is separated by one empty space
            //Console.Write("The winning lotto numbers are: ");
            //for (int index = 0; index < numberArray.Length; index++)
            //{
            //    Console.Write($"{numberArray[index]} ");
            //}
            foreach (int number in numberArray)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

        }


    }
}
