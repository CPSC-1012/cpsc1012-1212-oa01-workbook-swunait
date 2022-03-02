using System;

using Cpsc1012;

namespace Question02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt and read in hours, minutes, and seconds
            int hours,
                minutes,
                seconds;
            int totalSeconds;

            hours = Utilities.PromptForPositiveNumber("Enter the hours: ");
            minutes = Utilities.PromptForPositiveNumber("Enter the minutes: ");
            seconds = Utilities.PromptForPositiveNumber("Enter the seconds: ");

            // Call CalculateSeconds method to return total seconds 
            totalSeconds = CalculateSeconds(hours, minutes, seconds);

            // Display the total seconds of the time components
            Console.WriteLine($"The total time in seconds is {totalSeconds}");

        }

        static int CalculateSeconds(int hours, int minutes, int seconds)
        {
            int totalSeconds = 0;
            totalSeconds = hours * 60 * 60 + minutes * 60 + seconds;
            return totalSeconds;
        }
    }
}
