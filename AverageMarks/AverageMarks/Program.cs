using System;

namespace AverageMarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students; // The number of students
            double mark; // Mark for a single student
            double totalMarks; // Total marks for all students
            double averageMark; // Average mark for all students
            string userInput;
            // Prompt and read in the number of students
            Console.WriteLine("How many students?");
            userInput = Console.ReadLine();
            students = int.Parse(userInput);
            // Set the accumulator to 0.
            totalMarks = 0;

            // For each student, prompt and read in their mark
            // and calculate a running total.
            for (int count = 1; count <= students; count += 1)
            {
                Console.WriteLine($"Enter mark for student #{count}:");
                userInput = Console.ReadLine();
                mark = double.Parse(userInput);
                totalMarks += mark;
            }
            // Calculate the average mark
            averageMark = totalMarks / students;
            // Display the average mark
            Console.WriteLine($"The average mark is {averageMark:F1}");
        }
    }
}
