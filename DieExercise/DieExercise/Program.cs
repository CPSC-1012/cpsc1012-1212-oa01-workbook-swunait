using System;

namespace DieExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"This simulates the rolling of a 6-sided die and a 12-sided die.
Initial value of the dice");

            // Create 6 sided Die and a 12 sided Die
            Die sixSidedDie = new Die(6);
            Die twelveSidedDie = new Die(12);

            Console.WriteLine($"{sixSidedDie.Value, 10} {twelveSidedDie.Value, 10}");
            // Simulate rolling the two Die 5 times
            Console.WriteLine($"Rolling the two Die 5 times.");
            for (int count = 1; count <= 5; count++)
            {
                sixSidedDie.Roll();
                twelveSidedDie.Roll();
                Console.WriteLine($"{sixSidedDie.Value,10} {twelveSidedDie.Value,10}");
            }
        }
    }
}
