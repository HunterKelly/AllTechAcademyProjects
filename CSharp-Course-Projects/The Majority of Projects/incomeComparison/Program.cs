using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Give Person1 hourly rate");
            string hourly = Console.ReadLine();
            int hourlyRate = Convert.ToInt32(hourly);

            Console.WriteLine("Give Person1 hours worked per week");
            string weekHours = Console.ReadLine();
            int totalHours = Convert.ToInt32(weekHours);

            Console.WriteLine("Give Person2 hourly rate");
            string hourly2 = Console.ReadLine();
            int hourlyRate2 = Convert.ToInt32(hourly2);

            Console.WriteLine("Give Person2 hours worked per week");
            string weekHours2 = Console.ReadLine();
            int totalHours2 = Convert.ToInt32(weekHours2);


            int annualSalary = ((totalHours * hourlyRate) * 52);
            int annualSalary2 = ((totalHours2 * hourlyRate2) * 52);

            Console.WriteLine("The Annual Salary of Person1 is " + annualSalary);
            Console.WriteLine("The Annual Salary of Person2 is " + annualSalary2);
            Console.ReadLine();

            Console.WriteLine("Does Person1 make more money than Person2?");
            bool largerSalary = annualSalary > annualSalary2;
            Console.Write(largerSalary);




        }
    }
}
