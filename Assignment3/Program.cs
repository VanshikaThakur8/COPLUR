using System;
using System.Collections.Generic;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> StudentScores = new Dictionary<string, int>();

            StudentScores.Add("Vanshika", 10);
            StudentScores.Add("Virat", 92);
            StudentScores.Add("Aarushi", 69);
            StudentScores.Add("Tanvi", 96);
            StudentScores.Add("Amita", 91);

            Console.WriteLine("Student Scores:");
            foreach (var student in StudentScores)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }

            StudentScores["Vanshika"] = 98;
            Console.WriteLine("\n Update Scores:");
            foreach (var student in StudentScores)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }

            StudentScores.Remove("Aarushi");
            Console.WriteLine("\nAfter Removing Aarushi:");
            foreach (var student in StudentScores)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }

            Console.WriteLine($"\nScore of Vanshika: {StudentScores["Vanshika"]}");
        }
    }
}
