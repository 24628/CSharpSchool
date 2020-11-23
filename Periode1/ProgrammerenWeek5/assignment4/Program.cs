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
                Console.Write("Enter a number (0 = stop): ");
                int input = Convert.ToInt32(Console.ReadLine());    
                tmpArray.Add(input);
                if(input == 0){
                    zeroNotStated = false;
                }
            }

            Console.Write("\nEnter a search value: "); 
            int searchValue = Convert.ToInt32(Console.ReadLine());
            int[] resultList = tmpArray.ToArray();
            int occurences = 0;
            
            foreach(int item in resultList){
                if(item == searchValue){
                    occurences++;
                }
            }

            Console.WriteLine("\nNumber of occurences of searchvalue (" + searchValue + ") is: " + occurences);
        }
    }
}
