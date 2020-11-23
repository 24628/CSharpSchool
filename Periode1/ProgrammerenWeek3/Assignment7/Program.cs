using System;
using System.Globalization;
using System.Threading;

//mcs the CS file to compile mcs Program.cs
//mono the exe file to run mono Program.exe
//do from terminal self note

namespace Assignment4
{
    class Program
    {
         static void Main(string[] args){
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            Console.Write("Enter weight (kg): ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter lenght (cm): ");
            int lenght = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter gender (male/female): ");
            string gender = Console.ReadLine();

            Console.WriteLine("bmi-value: " + String.Format("{0:0.0}", Convert.ToDouble(weight / Math.Sqrt(lenght))));
            Console.WriteLine("normal bmi-values (min .. max):" + (gender == "male" ? "20..25" : "19..24"));
            
         }
    }
}
