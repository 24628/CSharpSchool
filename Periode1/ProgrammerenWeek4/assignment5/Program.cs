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

            // Boolean zeroNotStated = true;

            // while(zeroNotStated){
            //     Console.Write("Enter a year: ");
            //     int input = Convert.ToInt32(Console.ReadLine());    

            //     if(input == 0) zeroNotStated = false;
            //     else if (input >= 1){
            //         if(DateTime.IsLeapYear(input)) Console.WriteLine(input + " is a leap year.");
            //         else Console.WriteLine(input + " is not a leap year.");
            //     } else Console.WriteLine("Year must be posistive!");
            // }

            while (jaartal != 0)
            {
            if (jaartal < 0)
            {
                Console.WriteLine("Year must be positive!");
            }
            else
            {
                if (((jaartal % 4 == 0) && (jaartal % 100 != 0)) || (jaartal % 400 == 0))
                {
                    Console.WriteLine("{0} is a leap year.", jaartal);
                }
                else
                {
                    Console.WriteLine("{0} is not a leap year.", jaartal);
                }
            }

            // lees volgend jaartal
            Console.Write("Enter a year: ");
            invoer = Console.ReadLine();
            jaartal = Int32.Parse(invoer);
        }
    }
}
