using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem4
{
    internal class Student
    {
        public string Name;
        public int Age;
        public double Grade;


        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public void DisplayInfo()   
        {
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Student Age: " + Age);
            Console.WriteLine("Student Grade: " + Grade);
            Console.WriteLine();
        }
    }   
}
