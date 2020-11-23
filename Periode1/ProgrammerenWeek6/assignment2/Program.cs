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
                Console.Write("Enter a number (0 = stop): ");
                int input = Convert.ToInt32(Console.ReadLine());    
                if(input == 0){
                    zeroNotStated = false;
                } else if(input > 0) {
                   Console.WriteLine(input + " is " + (IsPrimeNumber(input) == true ? " " : "not ") + "a prime number"); 
                } else {
                    Console.WriteLine("Negative number entered...");
                }
            }
        }

        static public bool IsPrimeNumber(int number){
            // for (int i = 2; i < num; i++)
            //     if (num % i == 0) return false;
            // return num > 1;
            if (number < 2) return false;

            bool isPrime = true;
            int i = 2;
            while ((i < number) && (isPrime))
            {
                if ((number % i) == 0)
                    isPrime = false;
                else
                    i++;
            }
            return isPrime;
        }
    }
}
