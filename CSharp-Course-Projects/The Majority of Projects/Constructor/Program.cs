using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            const string sky = "blue";
            const string leaves = "green";

            var number = 10;

            Console.WriteLine("The sky is {0}, The leaves are {1}.", sky, leaves);
            Console.WriteLine("Ten plus ten equals " + (number + number));
        }
    }
}
