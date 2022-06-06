using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace mainMethodAssignment
{
     public class Class1
    {
        public int math(decimal userInput)
        {
            decimal userInput2convert = userInput * 2;
            int userInputconvert2 = Convert.ToInt32(userInput2convert);
            return userInputconvert2;
        }

        public int math(int userInput2)
        {
            return userInput2 * userInput2;
            
        }

        public int math(string userInput3)
        {
            try
            {
                int userInput3convert = Convert.ToInt32(userInput3);

                //extra in case I wanted to bring it back as a string otherwise I would just leave it as
                //return userInput3convert / 2;
                int userInput3convertback = userInput3convert / 2;
                Convert.ToString(userInput3convertback);
                return userInput3convertback;
            }
            catch
            {

                Console.WriteLine("You have to type in a number");
                return 0;
            }
            
        }
    }
}
