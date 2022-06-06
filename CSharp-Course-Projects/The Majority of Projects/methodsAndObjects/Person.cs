using System;
using System.Collections.Generic;
using System.Text;

namespace methodsAndObjects
{
    public class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }

        public void SayName()
        {
            
                Console.WriteLine("Name: [" + FName + " " + LName + "]");
            }
        }
    }

