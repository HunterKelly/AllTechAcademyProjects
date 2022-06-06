using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates 10 new employee objects
            Employee emp1 = new Employee() {FName = "Joe", LName = "Nammath", EmpID = 1};
            Employee emp2 = new Employee() { FName = "Frank", LName = "Franky", EmpID = 2 };
            Employee emp3 = new Employee() { FName = "Joe", LName = "Gage", EmpID = 3 };
            Employee emp4 = new Employee() { FName = "Marquis", LName = "Warren", EmpID = 4 };
            Employee emp5 = new Employee() { FName = "John", LName = "Ruth", EmpID = 5 };
            Employee emp6 = new Employee() { FName = "Daisy", LName = "Domergue", EmpID = 6 };
            Employee emp7 = new Employee() { FName = "Sherrif", LName = "Chris", EmpID = 7 };
            Employee emp8 = new Employee() { FName = "Oswaldo", LName = "Mobray", EmpID = 8 };
            Employee emp9 = new Employee() { FName = "Sandy", LName = "Smithers", EmpID = 9 };
            Employee emp10 = new Employee() { FName = "SixHorse", LName = "Judy", EmpID = 10 };


            //creates list
            List<Employee> Employees = new List<Employee>()
            {                          

            };
            //adds employees to list
            Employees.Add(emp1);
            Employees.Add(emp2);
            Employees.Add(emp3);
            Employees.Add(emp4);
            Employees.Add(emp5);
            Employees.Add(emp6);
            Employees.Add(emp7);
            Employees.Add(emp8);
            Employees.Add(emp9);
            Employees.Add(emp10);

            //checks for duplicate Joes and puts them in a new list
            foreach (var emp in Employees)
            {
                if (emp.FName == "Joe")
                {
                    List<Employee> DupEmpName = new List<Employee>();
                    DupEmpName.Add(emp);
                    
                }
            }
            //does the same as above but lambda version
            List<Employee> newList = Employees.Where(x => x.FName == "Joe").ToList();

            //makes list of all employees with ID greater than 5
            List<Employee> newList2 = Employees.Where(x => x.EmpID > 5).ToList();


            Console.ReadLine();
            
        }
    }
}
