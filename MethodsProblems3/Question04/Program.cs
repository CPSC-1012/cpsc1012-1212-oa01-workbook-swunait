using System;

using Cpsc1012;

namespace Question04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt and read in length and width and height of rectangle
            int length,
                width,
                height;

            int area,
                volume;

            length = Utilities.PromptForPositiveNumber("Enter length of rectangle: ");
            // Call CalculateArea to return the area of the rectangle

            // Call CalculateVolume to return the volune of the rectangle

            // Display the area and volume of the rectangle
        }

        static int CalculateArea(int length, int width, int height)
        {
            int area = 0;
            area = 2 * (length * width + width * height + height * length);
            return area;
        }

        static int CalculateVolume(int length, int width, int height)
        {
            int volume = 0;
            volume = length * width * height;   
            return volume;
        }


    }
}
