using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_assignment
{
    public abstract class Person
    {
        public List<Employee> Emplist { get; set; }

        public int EmpID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

        public abstract void SayName();
        //{

        //    Console.WriteLine("Name: [" + FName + " " + LName + "]");
        //}

        
        
    }

}

