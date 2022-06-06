using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            try
            {
                int userAge = Convert.ToInt32(Console.ReadLine());
                int userYearBorn = 2022 - userAge;
                Console.WriteLine("You were born in " + userYearBorn + ".");
            }
            catch (zeroException)
            {
                Console.WriteLine("You cant enter 0 or a negative number");
                return;
            }

            catch (Exception)
            {
                Console.WriteLine("You must enter a whole number.");
                Console.ReadLine();
                return;
            }
            
        }
    }
}
