using System;

using System.IO;    // for File class

namespace FileIODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and create two parallel arrays for student names and student points
            const int MaxStudents = 25;
            int currentStudentCount = 0;
            string[] nameArray = new string[MaxStudents];
            int[] pointArray = new int[MaxStudents];
            // Read all the lines from the text file and return an array of lines
            string[] allLines = File.ReadAllLines(@"D:\temp\cpsc1012-points.txt");
            const char Delimiter = ',';
            for (int index = 0; index < allLines.Length && index < MaxStudents; index++) 
            { 
                string currentLine = allLines[index];
                string[] tokens = currentLine.Split(Delimiter);
                nameArray[index] = tokens[0];  
                pointArray[index] = int.Parse(tokens[1]);
                currentStudentCount++;
            }
            DisplayStudents(nameArray, pointArray, currentStudentCount);
        }

        static void DisplayStudents(string[] nameArray, int[] pointArray, int studentCount)
        {
           for (int index = 0; index < studentCount; index++)
            {
                Console.WriteLine($"{nameArray[index],-20} {pointArray[index],6}");
            }
        }
    }
}
