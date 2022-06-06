using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sixparter
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            //Problem 1
            //adds input to each string in the array
            string[] name = { "I am ", "You are ", "We are ", "They are " };

            Console.WriteLine("Input a verb");
            string userTest = Console.ReadLine();


            for (int j = 0; j < name.Length; j++)
            {
                name[j] = name[j] + userTest;

                if (j < name.Length)
                {
                    Console.WriteLine(name[j]);
                }
            }
            Console.ReadLine();



            //Problem 2
            //was an infinite loop
            for (int k = 0; k < name.Length; k++)
            {
                Console.WriteLine(k);
                //k = 0;  (the part that makes it infinite)
            }

            //separates the loop in the console for easy reading
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            //Problem 3
            //Loop that uses the < operator to iterate 
            int l = 0;
            for (l = 0; l < 5; l++)
            {
                Console.WriteLine(l);
                
            }
            Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            //Problem 3 Continued
            //Loop that uses the <= operator to iterate 
            int q = 0;
            for (q = 0; q <= 5; q++)
            {
                Console.WriteLine(q);

            }
            Console.ReadLine();


            //problem 4 I was stuck on this one, so I used several attempts and ways to get it to work, and I found a few ways to do it.
            List<string> shoppingList = new List<string>() { "Bananas", "Apples", "Beef", "Chicken" };
            Console.WriteLine("Search for an item in the grocery list");
            string userSearch = Console.ReadLine();



            for (int i = 0; i < shoppingList.Count; i++)
            {
                if (userSearch == shoppingList[i])
                {
                    Console.WriteLine(userSearch + " appears at index " + i);
                }


            }
                
                if (shoppingList.Contains(userSearch)) 
            {
                Console.WriteLine("");
            } else
            {
                Console.WriteLine(userSearch + " is not on the list");
            }
                Console.ReadLine();

            //Problem 5

            List<string> cars = new List<string> { "Mazda", "Ford", "Dodge", "Chevy", "Ford" };
            Console.WriteLine("Type in a car brand from the list");
            string userBrand = Console.ReadLine();


            for (int i = 0; i < cars.Count; i++) {
                if (userBrand == cars[i])
                {
                    Console.WriteLine(i);
                }


             }

            //Problem 6 

            List<string> presidents = new List<string>() { "Washington", "Clinton", "Bush", "Bush", "Obama" };
            List<string> duppresident = new List<string>();
            Console.WriteLine("Here is a list of Presidents");
            foreach (string president in presidents)
            {
                Console.WriteLine(president);
                if (duppresident.Contains(president))
                {
                    Console.WriteLine(president + " is a duplicate.");
                }
                else
                {
                    duppresident.Add(president);
                }
            }
            
           
            Console.ReadLine();

          





        }
         
    }
}

