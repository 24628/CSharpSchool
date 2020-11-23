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
            int [] array = new int[20];
            int smallestNumber = 0;
            int occurence = 0;
            for(int i = 0; i < array.Length; i++){
                array[i] = rnd.Next(0, 200);
                Console.WriteLine("Element " + i + " is " + array[i]);

                if(i != 0){
                    if(smallestNumber > array[i]){
                        smallestNumber = array[i];
                        occurence = 1;
                    } else if (smallestNumber == array[i]){
                        occurence++;
                    }
                } else {
                    smallestNumber = array[i];
                }
            } 

            Console.WriteLine("Smallest number = " + smallestNumber);
            Console.WriteLine("number of occurence = " + occurence);
        }
    }
}
