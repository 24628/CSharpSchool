using System;
using System.Globalization;
using System.Threading;

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
            string price = Console.ReadLine();

            double parsedPrice = Convert.ToDouble(price);
            double taxes = 1.21;

            double Vat = (taxes * parsedPrice) - parsedPrice;
            Console.Write("price: " + price + ", VAT: " + Vat + ", total: " + (taxes * parsedPrice));

         }
    }
}
