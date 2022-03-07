using System;

namespace ArrayDemoWIthMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: Prompt the user for the number of quick picks

            // TODO: For each quick pick generate 7 random numbers between 1 and 50
            // by calling the GenerateNumbers methods
            // and write the generated numbers to a text file
            int[] lottoNumberArray = GenerateNumbers(1, 50, 7);
            // Display all the numbers generated
            DisplayNumbers(lottoNumberArray);

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
            Console.Write("The winning lotto numbers are: ");
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
