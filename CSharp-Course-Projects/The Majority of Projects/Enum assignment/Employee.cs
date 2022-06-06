using System;
using System.Collections.Generic;
using System.Text;

namespace Enum_assignment
{
    public class Employee
    {
        public Day Days { get; set; }
        public enum Day
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
