/*	Name: Ebby Ezema
	Date: 09/10/2019
*/
using System;

namespace ISM_6225_WorkExp
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("How many years of exp do you have of professional programming?");
				string input = Console.ReadLine();
				decimal exp = decimal.Parse(input);

				if (exp > 2)
				{
					Console.WriteLine("Youre an expert!");
				}
				else if (exp == 2)
				{
					Console.WriteLine("Wow! You've been doing this for a little while");
				}

				else if (exp == 1)
				{
					Console.WriteLine("Looks like you have a little experience");
				}
				else
				{
					Console.WriteLine("Need lots of practices");
				}
			}
			catch
			{
				Console.WriteLine("Please use decimals");
			}
		}
	}
}
