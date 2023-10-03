using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Retry
{
    internal class Program
    {
        class Module
        {
            string name;
            string id;
            //students
            //moduleLead
        }

        class Student //List of Students
        {
            //Private member fields
            private string name;
            private string id;

            //Constructor
            public Student(string name, string id)
            {
                this.name = name;
                this.id = id;
            }

            //Public member methods
            public string GetID()
            {
                return id;
            }

            public string GetName()
            {
                return name;
            }

            public void Print() //Print student id and name
            {
                Console.WriteLine($"{id} - {name}");
            }
        }

        class Teacher
        {
            string name;
            string id;
            string title;
            int salary;
        }

        static void Main(string[] args) //For Testing purposes, since the VPL homework checker will run something like these
        {
            Student student1 = new Student("Gerald Wong", "0220001003"); //Grabs Student ID
            student1.Print();
        }
    }
}
