using System;

namespace methodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates the class with values
            Employee people = new Employee() { FName = "Sample", LName = "Student" };

            //calls the method
            people.SayName();
            Console.ReadLine();
                        

        }
    }
}
