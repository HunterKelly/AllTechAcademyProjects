using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheatreCMS3.Helpers
{
    public class TextHelpers
    {
        public static string CharacterLimiter(string text, int length)
        {
                if (string.IsNullOrEmpty(text)) return text;
            return text.Length <= length ? text : text.Substring(0, length) + "...";
        }

        public static string LimitWords(string text, int wordLimit)
        {
            if (string.IsNullOrEmpty(text)) return text;//check if string is null or empty and return if it is
            if (wordLimit <= 0) return text;//check if the sentence is even being limited
            int counter = 0;//used to count the number of words that have passed
            int place = 0;//used to keep track of what place in the string array the loop is at 
            bool alreadySpaced = false;//used to check for double spaces

            foreach (char letter in text)
            {
                if (letter == ' ')//check for spaces
                {
                    if(alreadySpaced == true)//check for double space
                    {
                        place++;
                        continue;
                    }
                    alreadySpaced = true;//mark that a space was just found
                    if (place == 0) //skip this space if the space was at the beginning of the string
                    { 
                        place++; 
                        continue; 
                    }
                    counter++;//count the number of words when a space is found
                    if (counter == wordLimit)//complete the loop if we've reached the wordLimit requested
                    {
                        break;
                    }
                }
                else
                {
                    alreadySpaced = false;//mark that the last letter checked was not just a space
                }
                place++;
            }
            return text.Substring(0, place) + "...";
        }
    }
}