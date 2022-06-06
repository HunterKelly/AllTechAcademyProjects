using System;

namespace BooleanComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the number that best answers the question.");
            Console.WriteLine("What is the scientific name of Corn?");
            Console.WriteLine("1 Cynodon Dactylon");
            Console.WriteLine("2 Zea Mays");
            Console.WriteLine("3 Quercus Virginicus");
            Console.WriteLine("4 Cypress Virens");
            bool isGuess = false;
            int number = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You guessed 1. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("That is correct!");
                        isGuess = true;
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3, Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You guessed 4, Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }

            while (!isGuess);
            bool x = false;
            Console.WriteLine("How many feet are in a mile?");
            int mile = Convert.ToInt32(Console.ReadLine());
            while (!x)
            {
                switch (mile) {

                    case 5280:
                        Console.WriteLine("That is correct!");
                        x = true;
                        break;
                    case 100:
                        Console.WriteLine("That is incorrect!");
                        Console.WriteLine("Try again!");
                        mile = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("That is incorrect!");
                        Console.WriteLine("Try again!");
                        mile = Convert.ToInt32(Console.ReadLine());
                        break;



                }
            }
        }
    }
}
