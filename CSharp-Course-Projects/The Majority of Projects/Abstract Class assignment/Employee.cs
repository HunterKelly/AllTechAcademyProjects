using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_assignment
{

    public class Employee : Person, IQuittable

    {

        
        public override void SayName()
        {
            {

               Console.WriteLine("Name: [" + FName + " " + LName + "]");
            }
        }
        public void Quit()
        {
            Console.WriteLine("The Employee quit");
        }

        
    }
}
