using System;

namespace Fahrenheit2Celsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, // Celsius temperature reading
                    fahrenheit; // Fahrenheit temperature reading
             // Prompt for Fahrenheit temperature and read it in.
            Console.WriteLine("Enter a Fahrenheit temperature: ");
            fahrenheit = double.Parse(Console.ReadLine());
            // Calculate the equivalent Celsius temperature

            celsius = (5.0 / 9.0) * (fahrenheit - 32);
            // Output the Celsius temperature
            Console.WriteLine();
            Console.WriteLine($"The equivalent Celsius temperature is {celsius}");
        }
    }
}
