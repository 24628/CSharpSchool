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

            Console.Write("Enter a text");
            string input = Console.ReadLine();    
            int nrOfFullStops, nrOfCommas, nrOfSemiColons;
            SearchText(input, out nrOfFullStops, out nrOfCommas, out nrOfSemiColons);
            Console.WriteLine("result: "+nrOfFullStops.ToString()+" full stops, "+nrOfCommas.ToString()+" commas, "+nrOfSemiColons.ToString()+" semicolons");
        }

        static public void SearchText(
            string str, 
            out int nrOfFullStops, 
            out int nrOfCommas, 
            out int nrOfSemiColons
        ) {
            nrOfFullStops = str.Split('.').Length - 1;
            nrOfCommas = str.Split(',').Length - 1;
            nrOfSemiColons = str.Split(';').Length - 1;
        }
    }
}
