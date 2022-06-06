using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimed
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine("Type in a number between 1-24");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //adds the users number to the time in hours
            DateTime userTime = now.AddHours(userInput);


            Console.WriteLine(userTime);
            Console.ReadLine();

        }
    }
}
