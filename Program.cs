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
           
        }

        class Student
        {

            private string name;
            private string id;

            public Student(string Name, string ID)
            {
                name = Name;
                id = ID;
            }

            public string GetID
            {
                get { return id; }
            }

            public string GetName
            {
                get { return name; }
            }
        }

        class Teacher
        {
            string name;
            string id;
            string title;
            int salary;
        }

        static void Main(string[] args)
        {
            Student Stu_obj = new Student("0220001003", "Gerald Wong");
            //Stu_obj.
        }
    }
}
