using System;

//mcs the CS file to compile mcs Program.cs
//mono the exe file to run mono Program.exe
//do from terminal self note

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args){
            Console.Write("Geef je naam ");
            string name = Console.ReadLine();

            Console.Write(name  + " is dit je eerste barchelor opleiding? ");
            string barchelorAntwoord = Console.ReadLine();

            if(barchelorAntwoord == "nee") {
                Console.WriteLine("het collegegeld voor dit collegejaar is volledig (2142.00 euro)");
                return;
            }

            Console.Write("Is dit een leeraren opleiding ");
            string leerlaarOpleidingAntwoord = Console.ReadLine();

            if(leerlaarOpleidingAntwoord == "ja"){
                Console.WriteLine("het collegegeld voor dit collegejaar is de helft (1071.00 euro), en volgend jaar ook de helft");
            } else {
                Console.WriteLine("het collegegeld voor dit collegejaar is de helft (1071.00 euro), en daarna volledig");
            }

            Console.ReadKey();
        }
    }
}
