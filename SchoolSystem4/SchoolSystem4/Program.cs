using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*    Student student1 = new Student();
                student1.Name = "Marwa";
                student1.Age = 23;
                student1.Grade = 90;

                Student student2 = new Student();
                student2.Name = "Dima";
                student2.Age = 22;
                student2.Grade = 92;

                Student student3 = new Student();
                student3.Name = "Hana";
                student3.Age = 21;
                student3.Grade = 78;*/
            Student student1 = new Student("Marwa", 23, 90);
            Student student2 = new Student("Dima", 22, 92);
            Student student3 = new Student("Hana", 21, 78);

            Console.WriteLine("===== Student Information =====");
            student1.DisplayInfo();
            student2.DisplayInfo();
            student3.DisplayInfo();

        }
    }
}
