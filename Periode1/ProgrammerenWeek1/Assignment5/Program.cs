using System;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("Count add all numbers:");
            Random rnd = new Random();
            int[] randomNumbers = {rnd.Next(101, 10000), rnd.Next(101, 10000), rnd.Next(101, 10000), rnd.Next(101, 10000)};
            int total = 0;

            for (int i = 0; i < randomNumbers.Length; i++) {
                total += randomNumbers[i];
                Console.WriteLine(randomNumbers[i]);
            }

            Console.WriteLine("What is the total outcome? ");
            string input = Console.ReadLine();

            int number;
            bool isInt = int.TryParse(input, out number);
            if(!isInt){
                Console.WriteLine("That is not a number");
                return;
            }

            if(number != total){
                Console.WriteLine("Oof thats wrong!");
                Console.WriteLine($"The correct awnser was: {total}, and you counted this: {number}! pweh disgusting!" );
                return;
            }

            Console.WriteLine("Your correct thats awesome!");
           
        }
    }
}