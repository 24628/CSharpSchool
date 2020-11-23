using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Your full name is " + firstName + " " + lastName);

            Console.WriteLine("Your full name is {0} {1}", firstName, lastName);

            Console.WriteLine($"Your full name is {firstName} {lastName}");

            Console.ReadKey();
        }
    }
}