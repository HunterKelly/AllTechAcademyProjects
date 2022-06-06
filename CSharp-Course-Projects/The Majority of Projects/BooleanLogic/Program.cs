using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ageNumber = Convert.ToInt32(age);
           

            Console.WriteLine("Have you ever had a DUI? Answer True or False.");
            string DUI = Console.ReadLine();
            bool DUIBool = Convert.ToBoolean(DUI);
            

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int ticketNumber = Convert.ToInt32(tickets);


            int qualified = 0;
            if (ageNumber > 15)
            {
                qualified++;
            }
            if (DUIBool == false)
            {
                qualified++;
            }
            if (ticketNumber < 4)
            {
                qualified++;
            }

            if (qualified == 3)
            {
                Console.WriteLine("Qualified");
            }
             else  {
                Console.WriteLine("Not Qualified");
            }

            int num1 = 4;
           int num2 = 5;
                string result = num1 < num2 ? "Num1 is less than num2" : "Num1 is greater than num2";
            Console.WriteLine(result);






        }
    }
}
