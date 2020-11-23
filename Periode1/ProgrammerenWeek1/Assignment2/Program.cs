using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            int age;
            bool result = int.TryParse(input, out age);
            if(!result){
                Console.WriteLine("That is not a number");
                return;
            }

            age = ++age;
            string output = age.ToString();

            Console.WriteLine("Next yaer you will be " + output + " years old.");
            Console.ReadKey();
        }
    }
}