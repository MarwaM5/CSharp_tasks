using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem5
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        protected string SchoolName { get; set; }

        // _internalCode is private, so it can ONLY be accessed inside the Person class.
        private string _internalCode;

        public Person(string name, int age, string schoolName)
        {
            Name = name;
            Age = age;
            SchoolName = schoolName;
            _internalCode = "AAA111";
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

}
