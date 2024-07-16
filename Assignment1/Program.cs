using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> fruits = new List<string>
        {
            "Cherry",
            "Papaya",
            "Strawberry",
            "Mango",
            "Lichi"
        };

        Console.WriteLine("List of fruits:");
         PrintList(fruits);


        fruits.Add("Apple");
        Console.WriteLine("\nAdd new fruit in the list:");
        PrintList(fruits);

        fruits.RemoveAt(1);
        Console.WriteLine("\nRemove second fruit from the list:");

        PrintList(fruits);

        Console.WriteLine($"\nThird fruit in the list is: {fruits[2]}");
          
            
         string fruitToCheck = "Cherry";
        bool containsFruit = fruits.Contains(fruitToCheck);
        Console.WriteLine($"\nDoes the list contain '{fruitToCheck}'? {containsFruit}");
            }

          static void PrintList(List<string>List)
    { 
            foreach (string item in List)
            {
            Console.WriteLine(item);
            }
        }
            }



    