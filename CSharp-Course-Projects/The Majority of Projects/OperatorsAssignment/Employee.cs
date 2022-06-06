using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAssignment
{
    public class Employee
    {
        public int EmpID { get; set; }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.EmpID == emp2.EmpID; 
        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.EmpID != emp2.EmpID;
        }

    }
}
