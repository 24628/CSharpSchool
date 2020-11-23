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
            
            List<int> preSchooler = new List<int>();
            List<int> child = new List<int>();
            List<int> adult = new List<int>();

            Boolean zeroNotStated = true;
            
            while(zeroNotStated){
                Console.Write("Enter age (0 = stop): ");
                int input = Convert.ToInt32(Console.ReadLine());    
                if(input < 4 && input > 0) preSchooler.Add(input);
                if(input > 3 && input < 18) child.Add(input);
                if(input > 17) adult.Add(input); 
                if(input == 0) zeroNotStated = false;
            }

            int [] preSchoolerArray = preSchooler.ToArray();
            int [] childArray = child.ToArray();
            int [] adultArray = adult.ToArray();

            loopResult(preSchoolerArray, preSchoolerArray.Length, "Preschooler");
            loopResult(childArray, childArray.Length, "Child");
            loopResult(adultArray, adultArray.Length, "Adult");
        }

        static public void loopResult(int[] Array, int lenght, string type){
            Console.WriteLine(type);
            int totalAge = 0, highestAge = 0;
            for(int i = 0; i < lenght; i++){
                Console.WriteLine(type + " " + i + " is " + Array[i] + " years old");
                totalAge += Array[i];
                if(i != 0){
                    if(highestAge < Array[i]) {
                        highestAge = Array[i];
                    }
                } else {
                    highestAge = Array[i];
                }
            }

            Console.WriteLine("\nAverage age: " + String.Format("{0:0.00}", Convert.ToDouble(totalAge) / lenght));
            Console.WriteLine("Oldest " + type + " is " + highestAge + "\n");
        }
    }
}
