using System;

namespace ValueReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total, value1 = 20, value2 = 40;
            // Call the Sum method, passing the contents of value1 and value2 as
            // arguments. Assign the return value in the total variable.
            total = Sum(value1, value2);
            // Display the contents of all these variables.
            Console.WriteLine($"The sum of {value1} + {value2} is {total}");
        }
        static int Sum(int num1, int num2)
        {
            int result; // result is a local variable
                        // Assign the value of num1 + num2 to result
            result = num1 + num2;
            // Return the value in the result variable
            return result;
        }

    }
}
