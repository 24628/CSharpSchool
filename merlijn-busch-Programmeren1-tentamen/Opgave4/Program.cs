using System;

//mcs the CS file to compile mcs Program.cs
//mono the exe file to run mono Program.exe
//do from terminal self note

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args){
            
            Random rnd = new Random();

            for(int i = 0; i < 10; i++ ){
                SomGetallenReeks(rnd.Next(1, 21),rnd.Next(1, 21));
            }
        }

        static void SomGetallenReeks(int getal1, int getal2){
            if(getal1 > getal2)
                return;

            if(getal1 == getal2){
                Console.WriteLine(getal1+ ".." + getal2 + " = " + getal1);
                return;
            }    

            int loopAmount = getal2 - getal1 + 1;
            int total = 0;
            for(int i = 0; i < loopAmount; i++){
                total += (getal1 + i);
            }
            Console.WriteLine(getal1+ ".." + getal2 + " = " + total);

        }
    }
}
