using System;

namespace SentinelValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int SenintelValue = 999;
            // Read an initial data
            Console.Write($"Enter an integer (the input ends if it is {SenintelValue}): ");
            int data = int.Parse(Console.ReadLine());
            // Keep reading until the input is 0
            int sum = 0;
            while (data != SenintelValue)
            {
                sum += data;
                // Read the next data
                Console.Write($"Enter an integer (the input ends if it is {SenintelValue}): ");
                data = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The sum is {sum}");

        }
    }
}
