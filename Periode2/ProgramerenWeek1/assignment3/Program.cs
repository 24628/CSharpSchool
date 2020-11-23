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
            YahtzeeGame yahtzee = new YahtzeeGame();
            yahtzee.init();

            PlayYathzee(yahtzee);
        }

        void PlayYathzee(YahtzeeGame game){

            int nrOfAttemps = 0;

            do {
                game.Throw();
                game.DisplayValues();
                Console.WriteLine("");

                nrOfAttemps++;
            } while (!game.Yathzee());

            Console.WriteLine("Number of attempts needed (Yathzee): " + nrOfAttemps);
        }
    }

    class Dice{
        public int value;
        static Random rnd = new Random();

        public void Throw(){
            value = rnd.Next(1,7);
        }

        public void DisplayValue(){
            Console.Write(value + " ");
        }
    }

    class YahtzeeGame {
        
        public Dice[] dices = new Dice[5];
        public void init(){

            for(int i = 0; i < dices.Length; i++){
                dices[i] = new Dice();
            }
        }
        public void Throw(){
            foreach(Dice d in dices){
                d.Throw();
            }
        }
        public void DisplayValues(){
            foreach(Dice d in dices){
                d.DisplayValue();
            }
        }

        public bool Yathzee(){
            
            foreach(Dice d in dices){
                if(dices[0].value != d.value)
                    return false;
            }

            return true;
        } 
    }
}
