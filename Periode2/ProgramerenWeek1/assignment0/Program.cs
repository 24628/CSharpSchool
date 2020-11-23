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
            
            Program myProgram = new Program();
            myProgram.start();
        }

        void start(){
            int value = ReadInt("enter a value: ");
            Console.WriteLine("You enterd {0}.", value);

            int age = ReadInt("enter a value: ", 0, 120);
            Console.WriteLine("You are {0} years old", age);

            string name = ReadString("what is your name?");
            Console.WriteLine("Nice meeting you {0}", name);

            Console.ReadKey();
        }

        int ReadInt(string question){
            Console.WriteLine(question);
            return Int32.Parse(Console.ReadLine());
        }

        int ReadInt(string question, int min, int max){

            int result;
            do {
                result = ReadInt(question);

                if(result < min || result > max)
                    Console.WriteLine("Please enter number between {0} and {1}", min, max);
            } while (result < min || result > max);
            return result;
        }

        string ReadString(string question){
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}
