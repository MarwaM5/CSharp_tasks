using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem5
{
    internal class Student : Person
    {
        public int Grade { get; set; }
        private string _studentId;
        public string StudentId
        {
            get { return _studentId; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("StudentId cannot be empty.");
                }
                _studentId = value;
            }
        }

        public Student(string name, int age, string schoolName, int grade, string studentId)
            : base(name, age, schoolName)
        {
            Grade = grade;
            StudentId = studentId;
        }

        public void DisplaySchoolName()
        {
            Console.WriteLine($"School: {SchoolName}");
        }
    }

}
