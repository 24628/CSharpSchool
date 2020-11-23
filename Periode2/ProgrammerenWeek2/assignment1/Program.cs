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
            int [,] m = new int[nrOfRows, nrOfColums];
            initMatrix2d(m);

            Console.WriteLine("\n");
            
            initMatrixLinear(m);
        }

        void initMatrixLinear(int[,] matrix){
            int i;
            int row = 0, column = 1;
            
            for (i = 1; i <= matrix.GetLength(1) * matrix.GetLength(0); i++) {
                matrix[row, (column -1)] = i;
                if (i % matrix.GetLength(1) == 0) {
                    row++;
                    column = 0;
                }
                column++;
            }
            DisplayMatrixWithCross(matrix);
        }

        void DisplayMatrixWithCross(int[,] matrix){
            for(int i = 0; i < matrix.GetLength(0); i++){
                for(int j = 0; j < matrix.GetLength(1); j++){
                    Console.ResetColor();
                    if(i == j) Console.ForegroundColor = ConsoleColor.Red;
                    if((matrix.GetLength(0) - i) == j + 1) Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(String.Format("{0,4}", matrix[i,j]));
                }
                Console.Write("\n");
            }
        }

        void initMatrix2d(int[,] matrix){
            int number = 1;
            for(int i = 0; i < matrix.GetLength(0); i++){
                for(int j = 0; j < matrix.GetLength(1); j++){
                    matrix[i,j] = number;
                    number++;
                }
            }
            displayMatrix(matrix);
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
}
