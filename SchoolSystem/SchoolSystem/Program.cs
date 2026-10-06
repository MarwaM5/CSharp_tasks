using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Marwa";
            int age = 23;
            int grade = 90;
            double average = 3.2;
            string gender = "female";
            bool isStudentActive = true;
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Active: " + isStudentActive);


            string[] student = { "Marwa", "Fatima", "Yasmeen", "Amani", "Dima", "Manwa", "Salsabeel" };
            Console.WriteLine("Student 1: "+student[0]);
            Console.WriteLine("Student 2: " + student[1]);
            Console.WriteLine("Student 3: " + student[2]);
            Console.WriteLine("Student 4: " + student[3]);
            Console.WriteLine("Student 5: " + student[4]);
            Console.WriteLine("Student 6: " + student[5]);
            Console.WriteLine("Student 7: " + student[6]);
            Console.WriteLine("Number of Students: "+ student.Length);



            Console.WriteLine("first student: "+student[0]);
            Console.WriteLine("last student: "+student[6]);
            student[1] = "jafar";
            Console.WriteLine("New student: " + student[1]);
            Console.WriteLine( student[0]);
            Console.WriteLine(student[1]);
            Console.WriteLine(student[2]);
            Console.WriteLine(student[3]);
            Console.WriteLine(student[4]);
            Console.WriteLine(student[5]);
            Console.WriteLine(student[6]);












        }
    }
}
