using System;
using System.Globalization;
using System.Threading;

//mcs the CS file to compile mcs Program.cs
//mono the exe file to run mono Program.exe
//do from terminal self note

namespace Assignment4
{
    class Program
    {
         static void Main(string[] args){
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            Console.Write("Enter the first number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
                if(number < 60){
                    Console.WriteLine("grade: F \ncourse not passed");
                } else if (number < 70){
                    Console.WriteLine("grade: D \ncourse not passed");
                } else if (number < 80){
                    Console.WriteLine("grade: C \ncourse passed");
                } else if (number < 90){
                    Console.WriteLine("grade: B \ncourse passed");
                } else if (number < 101){
                    Console.WriteLine("grade: A \ncourse passed");
                } else {
                    Console.WriteLine("incorrect number");
                }
        }
    }
}
