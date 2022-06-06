using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSubmission
{
    public class  Class1
    {

        public void alphaClass(int userInput)
        {
            int userAnswer = userInput / 2;
            Console.WriteLine(userAnswer);
        }

        public void alphaClass(string userText)
        {

            Console.WriteLine("You typed " + userText);


        }

        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }

        

    }
}
