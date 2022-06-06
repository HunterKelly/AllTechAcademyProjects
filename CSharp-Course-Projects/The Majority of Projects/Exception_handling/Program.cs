using System;
using System.Collections.Generic;
namespace Exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>() { 5, 10, 20, 40, 50 };
            Console.WriteLine("Here is a list of numbers: 5, 10, 20, 40, 50" );
            try
            {
                Console.WriteLine("Pick a number to divide the list by.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Dividing the list numbers by your choice...");

                //for loops are da bomb!(iterates the list and divides by user input)
                for(int i = 0; i < numberList.Count; i++)
                {
                    int numberTwo = numberList[i] / numberOne;
                    Console.WriteLine(numberList[i] + " divided by " + numberOne + " equals " + numberTwo);
                }
                
            }
           //first catch is if they input a non number 
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
                return;
            }

            //this catch is to prevent the universe from exploding
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }

            //this catch is if somehow the universe DID explode.
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //a chance to read the damage
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
