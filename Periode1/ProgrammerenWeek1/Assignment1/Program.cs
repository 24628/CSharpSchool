using System;

//mcs the CS file to compile mcs Program.cs
//mono the exe file to run mono Program.exe
//do from terminal self note

namespace Assignment1
{
    class Program
    {
         static void Main(string[] args){
            string name;

            Console.WriteLine("what is your name? ");
            name = Console.ReadLine();

            Console.WriteLine("what is your age? ");
            string age = Console.ReadLine();

            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Your age is: " + age);

            Console.ReadKey();
         }
    }
}
