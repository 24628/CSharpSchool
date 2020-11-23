using System;
using System.Globalization;
using System.Threading;

//mcs the CS file to compile mcs Program.cs
//mono the exe file to run mono Program.exe
//do from terminal self note

namespace Assignment3
{
    class Program
    {
         static void Main(string[] args){
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;
            
            Console.Write("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sum = " + (firstNumber + secondNumber + thirdNumber));
            Console.WriteLine("average = " + (Convert.ToDouble(firstNumber + secondNumber + thirdNumber) / 3.00));
            Console.WriteLine("product = " + (firstNumber * secondNumber * thirdNumber));
            Console.WriteLine("product = " + (firstNumber * secondNumber * thirdNumber));
         }
    }
}
