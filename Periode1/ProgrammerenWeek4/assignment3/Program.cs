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
            
            List<int> tmpArray = new List<int>();
            Boolean zeroNotStated = true;
            
            while(zeroNotStated){
                Console.Write("Enter a number: ");
                int input = Convert.ToInt32(Console.ReadLine());    
                tmpArray.Add(input);
                if(input == 0){
                    zeroNotStated = false;
                }
            }

            int[] resultList = tmpArray.ToArray();
            int total = 0;
            int keepTrackOfDevisionBy5 = 0;
            foreach(int item in resultList){
                keepTrackOfDevisionBy5++;
                if(keepTrackOfDevisionBy5 % 5 == 0){
                    total += item;
                }
            }

            Console.WriteLine("Count of numbers equal to target number: " + total.ToString());
        }
    }
}
