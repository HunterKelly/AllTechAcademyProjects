using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Abstract_Class_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable person1 = new Employee();

           
                        




            //instantiates the class with values
            Employee people = new Employee() { FName = "Sample", LName = "Student", EmpID = 2 };

            //calls the method
            people.SayName();
            Console.ReadLine();
            person1.Quit();

            

        }
        
    }
}
