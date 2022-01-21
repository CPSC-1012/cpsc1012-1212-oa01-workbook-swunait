using System;

namespace ChineseZodiac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            switch (year % 12)
            {
                case 0: Console.WriteLine("monkey"); break;
                case 1: Console.WriteLine("rooster"); break;
                case 2: Console.WriteLine("dog"); break;
                case 3: Console.WriteLine("pig"); break;
                case 4: Console.WriteLine("rat"); break;
                case 5: Console.WriteLine("ox"); break;
                case 6: Console.WriteLine("tiger"); break;
                case 7: Console.WriteLine("rabbit"); break;
                 case 8: Console.WriteLine("dragon"); break;
                case 9: Console.WriteLine("snake"); break;
                case 10: Console.WriteLine("horse"); break;
                case 11: Console.WriteLine("sheep"); break;
                default:
                    Console.WriteLine("logical error");
                    break;

            }

        }
    }
}
