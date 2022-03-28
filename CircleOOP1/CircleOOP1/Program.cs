using System;

namespace CircleOOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Circle with a radius of 1
            Circle circle1 = new Circle();
            // The radius of circle1 should be 1,
            // area should be 3.14159
            // perimeter should be 6.28
            Console.WriteLine($"The radius of circle1 is {circle1.Radius}");
            Console.WriteLine($"The area of circle1 is {circle1.Area()}");
            Console.WriteLine($"The perimeter of circle1 is {circle1.Perimeter()}");

            // Change the radius of circle1 to 5
            circle1.Radius = 5;
            // The radius of circle1 should be 5,
            // area should be 78.53982
            // perimeter should be 31.41593
            Console.WriteLine($"The radius of circle1 is {circle1.Radius}");
            Console.WriteLine($"The area of circle1 is {circle1.Area()}");
            Console.WriteLine($"The perimeter of circle1 is {circle1.Perimeter()}");

            // Change the radius of cirlce1 to -25
            // It should throw an exception
            try
            {
                circle1.Radius = -25;
                Console.WriteLine("A exception should have been thrown");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
