using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Marwa", "Salsabeel", "Dima", "Manwa", "Hana" };
            int[] grades = { 90, 92, 80, 85, 70 };
            foreach (int i in grades)
            {
                Console.WriteLine(i);

            }

            int choice;

            do
            {
                Console.WriteLine("\n===== School System =====");
                Console.WriteLine("1. Display Students");
                Console.WriteLine("2. Search for Student");
                Console.WriteLine("3. Check Student Result");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine(students[i]);
                        }

                 
                        break;

                    case 2:
                        Console.Write("Enter student name: ");
                        string searchName = Console.ReadLine();

                        int index = 0;

                        while (index < students.Length)
                        {
                            if (students[index].ToLower() == searchName.ToLower())
                            {
                                Console.WriteLine("Student Found!");
                                break;
                            }

                            index++;
                        }

                        if (index == students.Length)
                        {
                            Console.WriteLine("Student Not Found.");
                        }
                        break;

                    case 3:
                        Console.Write("Enter student's grade: ");
                        int gradeInput = Convert.ToInt32(Console.ReadLine());

                        if (gradeInput >= 90 && gradeInput <= 100)
                            Console.WriteLine("Excellent");
                        else if (gradeInput >= 80 && gradeInput <= 89)
                            Console.WriteLine("Very Good");
                        else if (gradeInput >= 70 && gradeInput <= 79)
                            Console.WriteLine("Good");
                        else if (gradeInput >= 60 && gradeInput <= 69)
                            Console.WriteLine("Pass");
                        else if (gradeInput >= 0 && gradeInput < 60)
                            Console.WriteLine("Fail");
                        else
                            Console.WriteLine("Invalid grade.");

                        break;

                    case 4:
                        Console.WriteLine("BYEEE");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 4);









        }
    }
}
