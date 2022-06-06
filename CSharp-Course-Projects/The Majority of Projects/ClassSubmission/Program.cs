using System;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 divide = new Class1();
            int a = 100;

            Console.WriteLine("Type in a number to divide 2.");
            int userInput = Convert.ToInt32(Console.ReadLine());
            divide.alphaClass(userInput);

            Console.WriteLine("Type in any sentence");
            string userText = Console.ReadLine();
            divide.alphaClass(userText);

            Class2.betaClass();

            Console.WriteLine("This next method outputs a changed value. Originally the value passed in was 100.");
            divide.getValue(out  a);
            Console.WriteLine("value of a: {0}", a);
            Console.ReadLine();
            
        }
    }
}
