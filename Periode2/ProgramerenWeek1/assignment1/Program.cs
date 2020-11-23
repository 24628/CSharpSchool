using System;
using System.Globalization;
using System.Threading;

//mcs the CS file to compile mcs Program.cs
//mono the exe file to run mono Program.exe
//do from terminal self note

namespace Assignment1
{
    public enum Months {
        January=1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    class Program
    {
        static void Main(string[] args){
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            Program myProgram = new Program();
            myProgram.start();
        }

        void start(){
            PrintMonths();
            Months result = ReadMonth("Enter a month number:");
            Console.WriteLine((int)result + " => " + result);
        }

        void PrintMonth(Months m){
            Console.WriteLine((int)m + ". " + m);
        }

        void PrintMonths(){
            for(Months m = Months.January; m <= Months.December; m++){
                PrintMonth(m);
            }
        }
        Months ReadMonth(string question){

            Months result;
            int input;
            do {
                Console.WriteLine(question);
                input = Int32.Parse(Console.ReadLine());

                if(input < 1 || input > 12) {
                    Console.WriteLine("Please enter number between {0} and {1}", 1, 12);
                    result = Months.January;
                } else {
                    result = (Months)input;
                }
            } while (input < 1 || input > 12);
            return result;
        }
    }
}
