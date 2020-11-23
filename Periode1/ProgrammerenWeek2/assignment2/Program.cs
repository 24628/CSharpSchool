using System;
using System.Globalization;
using System.Threading;

//mcs the CS file to compile mcs Program.cs
//mono the exe file to run mono Program.exe
//do from terminal self note

namespace Assignment1
{
    class Program
    {
         static void Main(string[] args){
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            int total = 0;
            for (int i = 0; i < 3; i++) {
                Console.Write("Enter a number: ");
                string number = Console.ReadLine();
                total = total + Convert.ToInt32(number);
            }

            float result =  Convert.ToSingle(total) / 3;
            Console.WriteLine("The average is: " + result);
         }
    }
}
