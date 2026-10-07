using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name: ");
            String name= Console.ReadLine();

            Console.WriteLine("Enter Your Age: ");
            int age= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your Grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Your Average: ");
            double avg= Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter Your Gender: ");
            string gender= Console.ReadLine();


            Console.WriteLine("===== Student Report =====");
            Console.WriteLine("Welcome " + name + " !");
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age:  " + age);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Average: " + avg);
            Console.WriteLine("Gender: " + gender);

            Console.WriteLine();
            Console.WriteLine("===== Name Information =====");
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name[0]);

            Console.WriteLine();
            Console.WriteLine("original AVG: " + avg);
            Console.WriteLine("Bonus Marks: 5");
            double newAvg = avg+5;
            Console.WriteLine("NewAvg:" + newAvg);
            

            Console.WriteLine();
            Console.WriteLine("===== Student Status =====");
            
            if (newAvg >= 50)
            {
                Console.WriteLine("Result: Passed");

            }
            else
            {
                Console.WriteLine("Result: Failed");
            }

            if (age >= 18)
            {
                Console.WriteLine("Adult: "+ true);
            }

            else
            {
                Console.WriteLine("Adult: " + false);
            }


















        }
    }
}
