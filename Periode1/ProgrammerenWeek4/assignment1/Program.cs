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
                if(input >= 0){
                    tmpArray.Add(input);
                }
                if(input == 0){
                    zeroNotStated = false;
                }
            }

            int[] resultList = tmpArray.ToArray();
            double total = 0.00;
            foreach(int item in resultList){
                total += Convert.ToDouble(item);
            }

            Console.WriteLine("Average of all positive numbers is: " + String.Format("{0:0.00}", (total / resultList.Length)));
        }
    }
}
