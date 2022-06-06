using System;

namespace Enum_assignment
{
    class Program
    {
		
			

		
		   enum Week
		{
			Monday,
			Tuesday,
			Wednesday,
			Thursday,
			Friday,
			Saturday,
			Sunday
		}

		public static void Main()
		{
			Console.WriteLine("Enter the current day of the week");
			string userInput = Console.ReadLine();
			try
			{
				Week userInput2 = (Week)Enum.Parse(typeof(Week), userInput);




				Console.WriteLine(userInput2);
			} catch
            {
				Console.WriteLine("You have to enter an actual day of the week.");
            }
		}
	}
        


    }
        
   
         
    


