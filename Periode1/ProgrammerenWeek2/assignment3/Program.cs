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

            Console.Write("Enter seconds: ");
            string totalSeconds = Console.ReadLine();

            TimeSpan time = TimeSpan.FromSeconds(Convert.ToInt32(totalSeconds));
            string result = time.ToString(@"hh\:mm\:ss");
            Console.WriteLine(result);
         }
    }
}
