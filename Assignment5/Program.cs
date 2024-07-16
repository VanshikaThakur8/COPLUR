using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> studentScores = new Dictionary<string, List<int>>();

            studentScores.Add("Vanshu", new List<int> { 90, 95, 93 });
            studentScores.Add("Tanvi", new List<int> { 68, 74, 90 });
            studentScores.Add("Amita", new List<int> { 66, 80, 79 });

            Console.WriteLine("Student Scores:");
            foreach (var student in studentScores)
            {
                Console.WriteLine($"{student.Key}: {string.Join(", ", student.Value)}");
            }

            Console.WriteLine("\nAverage Scores:");
            Dictionary<string, double> studentAverages = new Dictionary<string, double>();
            foreach (var student in studentScores)
            {
                double average = student.Value.Average();
                studentAverages.Add(student.Key, average);
                Console.WriteLine($"{student.Key}: {average}");
            }

            var topStudent = studentAverages.Aggregate((x, y) => x.Value > y.Value ? x : y);
            Console.WriteLine($"\nTop Student: {topStudent.Key} with an average score of {topStudent.Value}");
        }
    }
}