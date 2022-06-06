using System;

namespace methodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            mathclass math = new mathclass();
            Console.WriteLine("Type a number to perform math on, we will multiply it by another.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            try
            {
                
            
                Console.WriteLine("Type a second number to multiply the first, you dont have to input a second number and then the first number will just be squared.");
                
                    int userInput2 = Convert.ToInt32(Console.ReadLine());
                    int result = math.multiply(userInput, userInput2);
                    Console.WriteLine(userInput + " times " + userInput2 + " equals " + result);
                    Console.ReadLine();
                
            }
            catch
            {
                int result = math.multiply(userInput);
                Console.WriteLine(userInput + " times default value of zero equals " + result);
            }
        }
    }
}
