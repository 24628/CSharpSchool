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
            
            Console.Write("Enter target number: ");
            int targetNumber = Convert.ToInt32(Console.ReadLine());

            while(zeroNotStated){
                Console.Write("Enter a number: ");
                int input = Convert.ToInt32(Console.ReadLine());    
                tmpArray.Add(input);
                if(input == 0){
                    zeroNotStated = false;
                }
            }

            int[] resultList = tmpArray.ToArray();
            double total = 0;
            foreach(int item in resultList){
                if(targetNumber == item){
                    total++;
                }
            }

            Console.WriteLine("Count of numbers equal to target number: " + total);
        }
    }
}
