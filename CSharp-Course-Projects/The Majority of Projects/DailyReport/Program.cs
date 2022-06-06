using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {

            //asks the question and saves it to a variable
            Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("");
            Console.WriteLine("What is your name");
            string fName = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();


            //Converts to an int value
            Console.WriteLine("");
            Console.WriteLine("What page number?");
            string coursePage = Console.ReadLine();
            int pageNumber = Convert.ToInt32(coursePage);


            //converts to a bool value
            Console.WriteLine("");
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string studentHelp = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(studentHelp);

            Console.WriteLine("");
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperience = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Is there any other feedback you'd like to provide? Okease be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int totalStudyHours = Convert.ToInt32(studyHours);

            Console.WriteLine("");
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");


            int x = 3;
            int y = 5;
            int addition = x + y;
            Console.WriteLine(addition);
            Console.Read();

            int num1 = 7;
            float num2 = 5.5f;
            float total = num1 + num2;
            Console.WriteLine(total);
            Console.Read();
        }
    }
}
