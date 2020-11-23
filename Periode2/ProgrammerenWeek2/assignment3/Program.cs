using System;
using System.Globalization;
using System.Threading;

//mcs the CS file to compile mcs Program.cs
//mono the exe file to run mono Program.exe
//do from terminal self note

namespace Assignment1
{
    public enum RegularCandies{
        JellyBean, // red
        Lozenge, // orange
        LemonDrop, // yellow
        GumSquare, // green
        LollipopHead, // blue
        JujubeCluster, // purple
    }

    class Program
    {
        static void Main(string[] args){
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            if(args.Length != 2) {
                Console.WriteLine("Invalid number of arguments");
                Console.WriteLine("usage: assignment[1-3] <nrOfRows> <nrOfColums>");
                return;
            }

            int nrOfRows = int.Parse(args[0]);
            int nrOfColums = int.Parse(args[1]);

            Program myProgram = new Program();
            myProgram.start(nrOfRows, nrOfColums);
        }

        void start(int nrOfRows, int nrOfColums){
            RegularCandies[,] pf = new RegularCandies[nrOfRows, nrOfColums]; 
            RegularCandies[,] playingField = initCandies(pf);
            displayCandies(playingField);
            Console.WriteLine((ScoreRowPresent(playingField)) ? "row found" : "no row score");
            Console.WriteLine((ScoreColumnPresent(playingField)) ? "column found" : "no column score");
        }

        RegularCandies[,] initCandies(RegularCandies[,] playingField){
            Array values = Enum.GetValues(typeof(RegularCandies));
            Random random = new Random();
            for(int i = 0; i < playingField.GetLength(0); i++){
                for(int j = 0; j < playingField.GetLength(1); j++){
                    playingField[i,j] = (RegularCandies)values.GetValue(random.Next(values.Length));
                }
            }
            return playingField;
        }

        void displayCandies(RegularCandies[,] playingField) {
            for(int i = 0; i < playingField.GetLength(0); i++){
                for(int j = 0; j < playingField.GetLength(1); j++){
                    Console.ResetColor();
                    switch((int)playingField[i,j]){
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.DarkCyan; // deze kleur is veranderd ze hadden orange je niet en ik ben kleuren blind dus zie het slecht
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.DarkMagenta; // deze kleur is veranderd ze hadden orange je niet en ik ben kleuren blind dus zie het slecht
                            break;
                    }
                    Console.Write("# ");
                }
                Console.Write("\n");
            }
            Console.ResetColor();
        }
        bool ScoreRowPresent(RegularCandies[,] playingField){
            for(int i = 0; i < playingField.GetLength(0); i++){
                for(int j = 0; j < playingField.GetLength(1); j++){
                    if(j > 2){
                        if((int)playingField[i,j] == (int)playingField[i,(j - 1)] && (int)playingField[i,j] == (int)playingField[i,(j - 2)]){
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        bool ScoreColumnPresent(RegularCandies[,] playingField){
            for(int i = 0; i < playingField.GetLength(0); i++){
                for(int j = 0; j < playingField.GetLength(1); j++){
                    if(i > 2){
                        if((int)playingField[i,j] == (int)playingField[(i - 1),j] && (int)playingField[i,j] == (int)playingField[(i- 2),j]){
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
