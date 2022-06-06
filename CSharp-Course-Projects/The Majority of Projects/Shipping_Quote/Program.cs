using System;

namespace Shipping_Quote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("What is the weight of the package?");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.Read();
                Environment.Exit(0);
            }

            Console.WriteLine("What is the width of the package?");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the height of the package?");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the length of the package?");
            int length = Convert.ToInt32(Console.ReadLine());

            int totalSize = length + height + width;

            if (totalSize > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express.");
                Console.Read();
                Environment.Exit(0);
            }
            int total = ((length * height * width) * weight) / 100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + total + ".00");
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
