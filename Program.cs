using System;

namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Would you like to start ?\n(yes or no)");
			
			var answer = Console.ReadLine();
			
			switch (answer) 
			{
				case "yes":
					{
						Console.WriteLine("Good\nLet us begin...");	
						Console.ReadLine();
						break;
					}
					
				case "no":
					{
						Console.WriteLine("Goodbye");
						Console.ReadLine();
						break;
					}
			}
		}
	}
}
