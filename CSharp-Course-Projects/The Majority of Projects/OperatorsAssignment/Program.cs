using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //create 2 new employees to compare with the overloaded operator
            Employee emp1 = new Employee();
            emp1.EmpID = 1;

            Employee emp2 = new Employee();
            emp2.EmpID = 3;


            //This is using the overload that is inside employee.cs
            Console.WriteLine(emp1 == emp2);

        }
    }
}
