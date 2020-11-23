using System;

//mcs the CS file to compile mcs Program.cs
//mono the exe file to run mono Program.exe
//do from terminal self note

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args){
            int[] randomNumberArray = new int[20];
            Random rnd = new Random();

            for(int i = 0; i < randomNumberArray.Length; i++ ){
                randomNumberArray[i] = rnd.Next(1, 100);
            }

            foreach(int number in randomNumberArray){
                 Console.ResetColor();
                if (number % 3 == 0 && number % 2 == 0){
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(number + " ");
                } else if (number % 3 == 0){
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(number + " ");
                } else if (number % 2 == 0){
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(number + " ");
                } else {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
