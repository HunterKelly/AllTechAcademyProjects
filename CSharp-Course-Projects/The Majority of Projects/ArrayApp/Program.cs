using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //choose your favorite color!
            string[] stringArray = { "Purple", "Red", "Blue", "Green" };

            Console.WriteLine("Select your favorite color from the following: ");
            Console.WriteLine("0 = Purple");
            Console.WriteLine("1 = Red");
            Console.WriteLine("2 = Blue");
            Console.WriteLine("3 = Green");
            bool isGuess = false;
            int userInput = Convert.ToInt32(Console.ReadLine());

            //error statement
            do
            {
                switch (userInput)
                {
                    case 0:
                        Console.WriteLine("You have choosen " + stringArray[userInput]);
                        isGuess = true;
                        break;

                    case 1:
                        Console.WriteLine("You have choosen " + stringArray[userInput]);
                        Console.ReadLine();
                        isGuess = true;
                        break;
                    case 2:
                        Console.WriteLine("You have choosen " + stringArray[userInput]);
                        Console.ReadLine();
                        isGuess = true;
                        break;
                    case 3:
                        Console.WriteLine("You have choosen " + stringArray[userInput]);
                        Console.ReadLine();
                        isGuess = true;
                        break;
                    default:
                        Console.WriteLine("Not a valid select, Please choose between 0 and 3.");
                        userInput = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuess);

            int[] intArray = { 2, 4, 8, 16, 32, 64, 128 };
            Console.WriteLine("Select your favorite number from the following: ");
            Console.WriteLine("0 = 2");
            Console.WriteLine("1 = 4");
            Console.WriteLine("2 = 8");
            Console.WriteLine("3 = 16");
            Console.WriteLine("4 = 32");
            Console.WriteLine("5 = 64");
            Console.WriteLine("6 = 128");
            isGuess = false;
            int userChoice = Convert.ToInt32(Console.ReadLine());

            //error statement
            do {
                switch (userChoice)
                {
                    case 0:
                        Console.WriteLine("You have choosen " + intArray[userChoice]);
                        Console.ReadLine();
                        isGuess = true;
                    break;
                    case 1:
                        Console.WriteLine("You have choosen " + intArray[userChoice]);
                        Console.ReadLine();
                        isGuess = true;
                        break;
                    case 2:
                        Console.WriteLine("You have choosen " + intArray[userChoice]);
                        Console.ReadLine();
                        isGuess = true;
                        break;
                    case 3:
                        Console.WriteLine("You have choosen " + intArray[userChoice]);
                        Console.ReadLine();
                        isGuess = true;
                        break;
                    case 4:
                        Console.WriteLine("You have choosen " + intArray[userChoice]);
                        Console.ReadLine();
                        isGuess = true;
                        break;
                    case 5:
                        Console.WriteLine("You have choosen " + intArray[userChoice]);
                        Console.ReadLine();
                        isGuess = true;
                        break;
                    case 6:
                        Console.WriteLine("You have choosen " + intArray[userChoice]);
                        Console.ReadLine();
                        isGuess = true;
                        break;

                    default:
                        Console.WriteLine("Not a valid select, Please choose between 0 and 6.");
                        userChoice = Convert.ToInt32(Console.ReadLine());
                    break;
                }   
            } while (!isGuess);

            List<string> stringList = new List<string>();
            stringList.Add("Hello");
            stringList.Add("Welcome");
            stringList.Add("Howdy");
            stringList.Add("Hola");

            Console.WriteLine("What is your favorite greeting? Choose the number that matches you're favorite!");
            Console.WriteLine("0 = Hello");
            Console.WriteLine("1 = Welcome");
            Console.WriteLine("2 = Howdy");
            Console.WriteLine("3 = Hola");
            int userChoice2 = Convert.ToInt32(Console.ReadLine());
            isGuess = false;
            

            do
            {
                switch (userChoice2)
                {
                    case 0:
                        Console.WriteLine(stringList[userChoice2] + ", thats my favorite too!");
                        isGuess = true;
                        Console.ReadLine();
                        break;
                    case 1:
                        Console.WriteLine(stringList[userChoice2] + ", thats my favorite too!");
                        Console.ReadLine();
                        isGuess = true;
                        break;
                    case 2:
                        Console.WriteLine(stringList[userChoice2] + ", thats my favorite too!");
                        Console.ReadLine();
                        isGuess = true;
                        break;
                    case 3:
                        Console.WriteLine(stringList[userChoice2] + ", thats my favorite too!");
                        Console.ReadLine();
                        isGuess = true;
                        break;
                    default:
                        Console.WriteLine("Not a valid select, Please choose between 0 and 3.");
                        userChoice2 = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            } while (!isGuess);

        }
    }
}
