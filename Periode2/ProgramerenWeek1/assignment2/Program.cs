using System;
using System.Globalization;
using System.Threading;

//mcs the CS file to compile mcs Program.cs
//mono the exe file to run mono Program.exe
//do from terminal self note

namespace Assignment1
{
    enum GenderType {
        m,
        f,
    }

    struct Person {
        public string Firstname;
        public string Lastname;
        public GenderType Gender;
        public int Age;
        public string City;
    }

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
            Person[] p = new Person[3];

            for(int i = 0; i < 3; i++){
                Person people = ReadPerson();
                p[i] = people;
            }

            foreach(Person person in p){
                printPerson(person);
            }

            Console.ReadKey();
        }

        Person ReadPerson(){
            Person person;
            
            person.Firstname = ReadString("\nEnter first name: ");
            person.Lastname = ReadString("Enter last name: ");
            person.Gender = ReadGender("Enter gender (m/f): ");
            person.Age = ReadInt("Enter age: ");
            person.City = ReadString("Enter city: ");

            return person;
        }

        void printPerson(Person p){
            Console.Write($"\n{p.Firstname} {p.Lastname}");
            PrintGender(p.Gender); 
            Console.Write($"\n{p.Age} years old, {p.City}");
        }

        GenderType ReadGender(string q){
            string input = ReadString(q);
            GenderType Gender = (GenderType)Enum.Parse(typeof(GenderType), input);
            return Gender;
        }

        void PrintGender(GenderType g){
            if((int)g == 0){
                Console.Write("(m)");
            } else {
                Console.Write("(f)");
            }
        }

        int ReadInt(string question){
            Console.Write(question);
            return Int32.Parse(Console.ReadLine());
        }

        string ReadString(string question){
            Console.Write(question);
            return Console.ReadLine();
        }
    }
}
