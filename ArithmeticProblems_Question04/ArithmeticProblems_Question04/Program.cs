/*  Purpose:    Sum the digits of a number
 *  
 *  Inputs:     A three digit number
 *  
 *  Outputs:    The sum of digits of the number
 *  
 *  Algorithm:  Step 1) Prompt and read in the number
 *              Step 2) Extract right most digit from number
 *                  digit1 = number % 10
 *              Step 3) Remove right most digit from the number
 *                  number = number / 10
 *              Step 4) Extract right most digit from number 
 *                  digit2 = number % 10
 *              Step 5) Remove right most digit from the number
 *                  number = number / 10
 *              Step 6) Extract right most digit from number   
 *                  digit3 = number % 10
 *              Step 7) Remove right most digit from the number
 *                  number = number / 10
 *              Step 8) Compute the sum of the digits as follows:
 *                  sum = digit1 + digit2 + digit3
 * */
using System;

namespace ArithmeticProblems_Question04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for inputs and outputs
            int originalNumber,
                number,
                digit1,
                digit2,
                digit3,
                sum;
            // Prompt and read in the number to sum
            Console.Write("Enter the number to sum digits for: ");
            originalNumber = int.Parse(Console.ReadLine());
            // Copy originalNumber to number
            number = originalNumber;
            // Extract RMD
            digit1 = number % 10;
            number = number / 10; 
            // Extract next RMD
            digit2 = number % 10;
            number = number / 10;
            // Extact next RMD
            digit3 = number % 10;
            number = number / 10;
            // Compute the sum
            sum = digit1 + digit2 + digit3;
            // Diplay the originalNumber and sum
            Console.WriteLine($"The sum of the number {originalNumber} is {sum}");


        }
    }
}
