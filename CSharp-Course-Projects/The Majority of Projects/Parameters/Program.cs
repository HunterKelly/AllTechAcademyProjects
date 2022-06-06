using System;
using System.Collections.Generic;
using System.Text;

namespace Parameters
{
    class Program
    {
        public static void Main(string[] args)
        {


            Employee<string> emp = new Employee<string>();
            emp.things = new List<string>();
            emp.things.Add("The first string");
            emp.things.Add("The second string");
            emp.things.Add("The third string");

            Employee<int> EmpInt = new Employee<int>();
            EmpInt.things = new List<int>();
            EmpInt.things.Add(1);
            EmpInt.things.Add(2);
            EmpInt.things.Add(3);

            for(int i = 0; i < emp.things.Count; i++)
            {
                Console.WriteLine(emp.things[i]);
            }

            for (int i = 0; i < EmpInt.things.Count; i++)
            {
                Console.WriteLine(EmpInt.things[i]);
            }

        }
    }
}
