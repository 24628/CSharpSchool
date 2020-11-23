using System;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("enter a number:" );
            string input = Console.ReadLine();

            int number;
            bool isInt = int.TryParse(input, out number);
            if(!isInt){
                Console.WriteLine("That is not a number");
                return;
            }

            int result = number + number;
            result = result / 2;
            result = result - number;

            Console.WriteLine($"result is {result}");
        }
    }
}