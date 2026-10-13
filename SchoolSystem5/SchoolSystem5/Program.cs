using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Marwa", 23, "Yarmouk", 90, "s1001");
            Student s2 = new Student("Dima", 25, "JUST", 80, "s2001");

          
            Teacher t1 = new Teacher("Ms.Yasmeen", 24, "Yarmouk", "Math");

         
            Console.WriteLine("===== Students =====");
            s1.DisplayInfo();
            s1.DisplaySchoolName();
            s2.DisplayInfo();
            s2.DisplaySchoolName();

            Console.WriteLine("\n===== Teacher =====");
            t1.DisplayTeacherInfo();

            Console.WriteLine("\n===== School Report =====");
            SchoolReport report = new SchoolReport("End of Year Report");
            report.DisplayReportTitle();

            // Person p = new Person("Test", 20, "Test School");
            // Console.WriteLine(p.SchoolName);    //  protected , not accessible from Main()
            // Console.WriteLine(p._internalCode); // private  , not accessible outside Person

            // SchoolName is protected , accessible only inside Person and its derived classes.
            // _internalCode is private , accessible only inside the Person class itself.
        }
    }
}
