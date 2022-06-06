using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainMethodAssignment
{
    class Program
    {
        public static void Main(string[] args)
            {
            Class1 class2 = new Class1();

                
                Console.WriteLine("Type a number to perform math on, we will squared it.");
                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(userInput + " squared equals " + class2.math(userInput));
                Console.ReadLine();


                Console.WriteLine("Type a decimal number to perform math on, we will multiply it by two.");
                decimal userInput2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine(userInput2 + " times 2 equals " + class2.math(userInput2));
                Console.ReadLine();

                Console.WriteLine("Type a number to perform math on, we will divide it by 2");
                string userInput3 = Console.ReadLine();
                Console.WriteLine(userInput3 + " divided by 2 equals " + class2.math(userInput3));
                Console.ReadLine();

        }
        
    }
}
