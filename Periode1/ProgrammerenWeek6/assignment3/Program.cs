using System;
using System.Globalization;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

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

            Boolean zeroNotStated = true;
            
            while(zeroNotStated){
                Console.Write("Enter year (0 = stop): ");
                int input = Convert.ToInt32(Console.ReadLine());    
                if(input == 0){
                    zeroNotStated = false;
                } else if(input > 0) {
                   Console.WriteLine(input + " is " + (IsLeapYear(input) == true ? "" : "not ") + "a leap year"); 
                } else {
                    Console.WriteLine("Negative year entered...");
                }
            }
        }

        static public bool IsLeapYear(int num){
            // return DateTime.IsLeapYear(num);
            return (input % 400 == 0 || input % 4 == 0 && input % 100 != 0);
        }
    }
}
