using System;

namespace ChineseZodiac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            string animalName;
            int offset = year % 12;
            switch (offset)
            {
                case 0: 
                    animalName = "monkey"; 
                    break;
                case 1: 
                    animalName = "rooster"; 
                    break;
                case 2:
                    animalName = "dog"; 
                    break;
                case 3:
                    animalName = "pig"; 
                    break;
                case 4:
                    animalName = "rat"; 
                    break;
                case 5:
                    animalName = "ox";
                    break;
                case 6:
                    animalName = "tiger";
                    break;
                case 7:
                    animalName =  "rabbit"; 
                    break;
                case 8: 
                    animalName = "dragon"; 
                    break;
                case 9:
                    animalName = "snake"; 
                    break;
                case 10:
                    animalName = "horse"; 
                    break;
                case 11:
                    animalName = "sheep"; 
                    break;
                default:
                    animalName = "logical error";
                    break;

            }
            Console.WriteLine($"Year of the {animalName} {year} ");

        }
    }
}
