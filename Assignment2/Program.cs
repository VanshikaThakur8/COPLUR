using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;

class Program
{
    static void Main(String[] args)
    {
        List<int> numbers = new List<int> { 99, 26, 10, 45, 66, 54, 32, 41, 82, 2 };

        numbers.Sort();
        Console.WriteLine("List arranged in ascending order:");
        PrintList(numbers);

        numbers.Sort((a, b) => b.CompareTo(a));
        Console.WriteLine("\nList arranged in descending order:");
        PrintList(numbers);

        int searchNumber = 10;
        bool found = numbers.Contains(searchNumber);
        Console.WriteLine($"\nIs the number {searchNumber} in the list? {found}");
    }
    static void PrintList(List<int> list)
    {
        foreach (int item in list)
    
      {
    Console.WriteLine(item);
       }
    }
}