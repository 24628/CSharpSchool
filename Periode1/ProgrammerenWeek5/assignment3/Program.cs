using System;
using System.Globalization;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

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
            
            Console.Write("Enter course name: ");
            string courseName = Console.ReadLine();
            Console.Write("Enter number of students: ");
            int studentAmount = Convert.ToInt32(Console.ReadLine());

            int [] notes = new int[studentAmount];
            string [] names = new string[studentAmount];
            int gradeTotal = 0, maxGradePosition = 0, highestGrade = 0;

            for(int i = 0; i < studentAmount; i++){
                Console.Write("Enter name of student " + (i + 1) + ": ");
                names[i] = Console.ReadLine();
            }

            for(int i = 0; i < studentAmount; i++){
                Console.Write("Enter grade of " + names[i] + ": ");
                notes[i] = Convert.ToInt32(Console.ReadLine());
                gradeTotal += notes[i];
                if(i != 0){
                    if(highestGrade < notes[i]) {
                        highestGrade = notes[i];
                        maxGradePosition = i;
                    }
                } else {
                    highestGrade = notes[i];
                }
            }

            Console.WriteLine("\nAverage grade: " + String.Format("{0:0.00}", Convert.ToDouble(gradeTotal) / studentAmount));
            Console.WriteLine("Student " + names[maxGradePosition] + " has the maximus grade: " +  notes[maxGradePosition].ToString() + "\n");

            for(int i = 0; i < studentAmount; i++){
                Console.WriteLine("Grade for student " + names[i] + " (course " + courseName + ") " + notes[i].ToString());
            }
        }
    }
}
