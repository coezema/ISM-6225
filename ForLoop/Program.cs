using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Years of exp?");
				string input = Console.ReadLine();
				int exp = int.Parse(input);

				for (int i = 0; i <= exp; i++)
				{
					if (i <= 1)
					{
						Console.WriteLine("You have " + i + " year of experience");
					}
					else
					{
						Console.WriteLine("You have " + i + " years of experience");
					}
				}
				Console.Write("Please press key to end program");
				Console.ReadKey(true);
			}
			catch
			{
				Console.Write("Please enter an integer");
			}
		}
	}
}
