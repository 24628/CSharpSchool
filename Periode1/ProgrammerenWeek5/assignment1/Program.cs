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
            
            Random rnd = new Random();
            int [] numbersArray = new int[20];
            double average = 0.00;
            for(int i = 0; i < numbersArray.Length; i++){
                numbersArray[i] = rnd.Next(0, 200);
                average += numbersArray[i];
                Console.WriteLine("Element " + i + " is " + numbersArray[i]);
            } 

            double calculatedAverage = Convert.ToDouble(average) / numbersArray.Length;
            Console.WriteLine("\nThe average is " + String.Format("{0:0.00}", calculatedAverage) + "\n");

            for(int i = 0; i < numbersArray.Length; i++){
                double item = Convert.ToDouble(numbersArray[i]);
                Console.WriteLine("Difference between average and elment " + i + " is " +
                String.Format("{0:0.00}",(item > calculatedAverage ? (item - calculatedAverage) * 2 : calculatedAverage - item))); 
            }
        }
    }
}
