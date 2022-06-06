using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is " + yourName);
            //Console.ReadLine();


            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int total = Convert.ToInt32(favoriteNumber);
            //Console.WriteLine("Your favorite number is " + total);
            //Console.Read();


            bool isStudying = false;
            byte hoursworked = 42;
            sbyte currentTemperature = -23;            
            char questionMark = '\u2103';
            decimal moneyInBank = 100.5m;

            double heightInCentimeters = 211.3020412345;

            float secondsLeft = 2.62f;
            short temperatureOnMars = -341;

            string myName = "Hunter";

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string raininStatus = Convert.ToString(isRaining);
            Console.WriteLine(raininStatus);
            Console.ReadLine();

            Console.WriteLine(questionMark);
            Console.Read();

        }
    }
}
