using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number.");
            int number = Convert.ToInt32(Console.ReadLine());
            string results = number == 12 ? "You have an awesome favorite number!" : "You do not have an awesome faovrite number.";
            Console.WriteLine(results);

            //int roomTemperature = 70;
            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hi " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("uuuhhhh. something went wrong");
            //}
            //Console.ReadLine();



            //int currentTemperature = 80;
            //int roomTemperature = 70;
            //string comparisonResult = currentTemperature == roomTemperature ? "It is exactly room temp." : "It is not room temp.";
            //Console.WriteLine(comparisonResult);
            


     //       if (currentTemperature == roomTemperature)
    //        {
    //            Console.WriteLine("It is exactly room temperature.");

    //        }
    //        else if (currentTemperature > roomTemperature)
    //        {
    //            Console.WriteLine("It is warmer than room temperature.");
    //        }
    //        else if (roomTemperature > currentTemperature)
    //        {
    //            Console.WriteLine("Room temperature is warmer than current temperature.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("It is not exactly room temperature.");
    //        }
            Console.ReadLine();
        }
    }
}
