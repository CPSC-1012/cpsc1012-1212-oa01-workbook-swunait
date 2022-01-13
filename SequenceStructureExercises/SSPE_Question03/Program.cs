/* Purpose: Compute the area of a hexagon
 * 
 * Input:   side of the hexagon
 * 
 * Output:  area of hexagon
 * 
 * Algorithm:   Step 1) Prompt and read the sides of the hexagon
 *              Step 2) Compute the area of the hexagon using the formula:
 *                  area = 3 x Sqrt(3) x side^2 / 2
 *              Step 3) Display the area of the hexagon
 * 
 * */
using System;

namespace SSPE_Question03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Step 1) Prompt and read the sides of the hexagon
            Console.Write("Enter the length of the side of the hexagon: ");
            double side = double.Parse(Console.ReadLine());
            // Step 2) Compute the area of the hexagon
            double area = (3 * Math.Sqrt(3) / 2) * (side * side) ;
            // Step 3) Display the area of the hexagon
            Console.WriteLine($"The area of the hexagon is {area:F4}");
            Console.WriteLine($"The area of the hexagon is {area}");

        }
    }
}
