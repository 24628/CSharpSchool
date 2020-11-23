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
            
            // int number1 = 0, number2 = 1, number3;
            // for(int i = 0; i < 20; i++){
            //     number3 = number1 + number2;
            //     Console.Write(number3+" ");
            //     number1 = number2;
            //     number2 = number3;
            // }
            int getal1 = 1;
            int getal2 = 1;

            Console.Write("{0}, {0}", getal1, getal2);
            int aantal = 2;

            while (aantal < 20)
            {
                int getal3 = getal1 + getal2;
                Console.Write(", {0}", getal3);

                getal1 = getal2;
                getal2 = getal3;

                aantal++;
            }
            Console.WriteLine();

            // wacht op gebruiker
            Console.ReadKey();
        }
    }
}
