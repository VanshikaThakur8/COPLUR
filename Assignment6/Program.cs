using System;

namespace Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Person, string> personEmails = new Dictionary<Person, string>();

            var person1 = new Person("Raj", "Sharma");
            var person2 = new Person("Amita", "Singh");
            var person3 = new Person("Shailendra", "Thakur");

            personEmails[person1] = "raj666@gmail.com";
            personEmails[person2] = "amita3030@gmail.com";
            personEmails[person3] = "thakshailu290@gmail.com";

            Console.WriteLine("Person Emails:");
            foreach (var entry in personEmails)
            {
                Console.WriteLine($"{entry.Key.FirstName} {entry.Key.LastName}: {entry.Value}");
            }

            personEmails[person2] = "amitasingh15@gmail.com";
            Console.WriteLine("\nUpdated Emails:");
            foreach (var entry in personEmails)
            {
                Console.WriteLine($"{entry.Key.FirstName} {entry.Key.LastName}: {entry.Value}");
            }

            personEmails.Remove(person3);
            Console.WriteLine("\nAfter Removing Shailendra Thakur:");
            foreach (var entry in personEmails)
            {
                Console.WriteLine($"{entry.Key.FirstName} {entry.Key.LastName}: {entry.Value}");
            }
        }
    }
}
