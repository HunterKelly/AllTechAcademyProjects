using System;

namespace Switch_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int mathProblem = 3;
                switch (mathProblem)
            {
                case 1:
                    Console.WriteLine("What is 1 plus 1?");
                    break;
                case 2:
                    Console.WriteLine("What is 2 plus 2?");
                    break;
                case 3:
                    Console.WriteLine("What is 4 plus 4?");
                    break;
                case 4:
                    Console.WriteLine("What is 8 plus 8?");
                    break;
                case 5:
                    Console.WriteLine("What is 16 plus 16?");
                    break;
            }
        }
    }
}
