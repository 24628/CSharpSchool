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
            Position pos = new Position();
            int [,] m = initMatrixRandom(new int[nrOfRows, nrOfColums], 1, 99);
            displayMatrix(m);
            Console.Write("\nEnter a number to search for: ");
            int num = int.Parse(Console.ReadLine());
            Position valueLast = pos.SearchNumberBackwards(m,num);
            Console.WriteLine("Number "+ num + " is found (first) at posistion [" + valueLast.row + "," + valueLast.column + "]");
            Position value = pos.SearchNumber(m,num);
            Console.WriteLine("Number "+ num + " is found (last) at posistion [" + value.row + "," + value.column + "]");
        }

        int[,] initMatrixRandom(int[,] matrix, int min, int max){
            Random rnd = new Random();
            for(int i = 0; i < matrix.GetLength(0); i++){
                for(int j = 0; j < matrix.GetLength(1); j++){
                    matrix[i,j] = rnd.Next(min, max);
                }
            }
            return matrix;
        }

        void displayMatrix(int[,] matrix){
            for(int i = 0; i < matrix.GetLength(0); i++){
                for(int j = 0; j < matrix.GetLength(1); j++){
                    Console.Write(String.Format("{0,4}", matrix[i,j]));
                }
                Console.Write("\n");
            }
        }
    }

    class Position {
        public int row;
        public int column;

        public Position SearchNumber(int[,] matrix, int number){
            Position pos = new Position();

            for(int i = 0; i < matrix.GetLength(0); i++){
                for(int j = 0; j < matrix.GetLength(1); j++){
                    if(matrix[i,j] == number) {
                        pos.row = i;
                        pos.column = j;
                    }
                }
            }    
            return pos;
        }

        public Position SearchNumberBackwards(int[,] matrix, int number){
            Position pos = new Position();

            for(int i = 0; i < matrix.GetLength(0); i++){
                for(int j = 0; j < matrix.GetLength(1); j++){
                    if(matrix[i,j] == number) {
                        pos.row = i;
                        pos.column = j;
                        return pos;
                    }
                }
            }    
            return pos;
        }
    }
}
