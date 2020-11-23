using System;

//mcs the CS file to compile mcs Program.cs
//mono the exe file to run mono Program.exe
//do from terminal self note

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args){
            Boolean zeroNotStated = true;
            
            while(zeroNotStated){
                Console.Write("Geef een woord op ");
                string woord = Console.ReadLine();  
                if(woord == "stop"){
                    zeroNotStated = false;
                    Console.WriteLine("\nEinde programma \n");
                } else {
                    int total = 0;
                    foreach(char letter in woord){
                        int value = letter - 96;
                        total += value;
                        Console.Write(letter  + "=" + value + " ");
                    }
                    Console.WriteLine("\nsom van `" + woord + "` is " + total + "\n");
                }
            }
        }
    }
}
