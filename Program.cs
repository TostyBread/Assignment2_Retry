using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment2_Retry
{
    internal class Program
    {

        static void Main(string[] args) //For Testing purposes, since the VPL homework checker will run something like these
        {
            Student student1 = new Student("Gerald Wong", "0220001003"); //sets Student ID

            // Access the student's name and ID using Get methods
            string Sname = student1.GetName();
            string id = student1.GetID();

            //Print the student's information
            student1.Print();


            Teacher teacher1 = new Teacher("Gerald", "10203", "Lecturer", 100);// Create a Teacher instance

            // Access the teacher's name using the getter method
            string Tname = teacher1.GetName();

            // Print the teacher's information
            teacher1.Print();
        }
    }

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
        private string Sname;
        private string id;

        //Constructor
        public Student(string Sname, string id)
        {
            this.Sname = Sname;
            this.id = id;
        }

        //Public member methods
        public string GetID()
        {
            return id;
        }

        public string GetName()
        {
            return Sname;
        }

        public void Print() //Print student id and name
        {
            Console.WriteLine($"{id} - {Sname}");
        }
    }

    class Teacher
    {
        //Private member fields
        private string Tname;
        private string id;
        private string title;
        private int salary;

        public Teacher(string Tname, string id, string title, int salary)
        {
            this.Tname = Tname;
            this.id = id;
            this.title = title;
            this.salary = salary;
        }
        // Getter for Name
        public string GetName()
        {
            return Tname;
        }

        public void Print()//Print Teacher's details
        {
            Console.WriteLine($"{id} - {Tname} - {title} - {salary}");
        }
    }
}
