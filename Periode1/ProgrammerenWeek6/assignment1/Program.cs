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

            Console.Write("Enter a price: ");
            float price =  float.Parse(Console.ReadLine());

            Console.WriteLine("price: " +  
                String.Format("{0:0.00}", price) + ", VAT: " + 
                String.Format("{0:0.00}", calcVat(price)) + ", total: " + 
                String.Format("{0:0.00}", calcVat(price) + price)
            );
        }

        static public float calcVat(float price){
            float VAT_PERC = 1.21f;
            return (price * vat) - price;
        }
    }
}
