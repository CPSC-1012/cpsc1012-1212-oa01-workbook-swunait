using System;

namespace CelsiusToFahrenheitTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = 0;
            Console.Write("Enter starting celsius value: ");

            int startingCelsius = int.Parse(Console.ReadLine());
            Console.Write("Enter ending celsius value: ");

            int endingCelsius = int.Parse(Console.ReadLine());

            Console.WriteLine($"{"Celsius",-10} {"Fahrenheit"}");
            Console.WriteLine($"{"-------",-10} {"----------"}");
            for (int celsius = startingCelsius; celsius <= endingCelsius; celsius++)
            {
                fahrenheit = (celsius * 9.0 / 5.0) + 32;
                fahrenheit = Math.Round(fahrenheit, 2);
                Console.WriteLine($"{celsius,-10} {fahrenheit}");
            }
        }
    }
}
