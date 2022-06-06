using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_methods
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Type a number to perform math on, we will squared it, multiply it by 2, and divide it by 2.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userInput + " squared equals " + theclass.squared(userInput));
            Console.WriteLine(userInput + " times 2 equals " + theclass.TimesTwo(userInput));
            Console.WriteLine(userInput + " divided by 2 equals " + theclass.divideTwo(userInput));


        }

         
        
    }
}
