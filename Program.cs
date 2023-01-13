using System;

namespace Program
{
	class Program
	{
		staic void Main(string[] args)
		{
			Console.WriteLine("Would you like to start ?\(yes or no)");
			
			answer = Console.ReadLine();
			
			switch (answer) 
			{
				case "yes":
					{
						Console.WriteLine("Good\nLet us begin...");		
					}
			}
		}
	}
}
