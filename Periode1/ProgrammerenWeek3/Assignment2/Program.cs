using System;
using System.Globalization;
using System.Threading;

//mcs the CS file to compile mcs Program.cs
//mono the exe file to run mono Program.exe
//do from terminal self note

namespace Assignment2
{
    class Program
    {
         static void Main(string[] args){
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;
            
            Console.Write("Enter number between (1.. 4): ");
            switch(Convert.ToInt32(Console.ReadLine())){
                case 1:
                    Console.WriteLine("Clubs");
                    break;
                case 2:
                    Console.WriteLine("Diamond");
                    break;
                case 3:
                    Console.WriteLine("Hearts");
                    break;
                case 4:
                    Console.WriteLine("Spades");
                    break;
                default:
                    Console.WriteLine("Incorrect number");
                    break;
            }
         }
    }
}
