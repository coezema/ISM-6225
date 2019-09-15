using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C.Ezema
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 1, b = 22;
			printSelfDividingNumbers(a, b);

			int n2 = 5;
			printSeries(n2);

			/*int n3 = 5;
			printTriangle(n3);

			int[] J = new int[] { 1, 3 };
			int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
			int r4 = numJewelsInStones(J, S);
			Console.WriteLine(r4);

			int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
			int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
			int[] r5 = getLargestCommonSubArray(arr1, arr2);
			Console.WriteLine(r5);

			solvePuzzle();
			*/
		}

		// 
		static bool isSelfDividing(int n)
		{
			int num = n;
			string alphanum = n.ToString();
			if (alphanum.Contains('0'))
			{
				return false;
			}
			else
			{
				while (num > 0)
				{ 
					int digit = num % 10;

					if (n % digit != 0)
					{
						return false;
					}
					else
					{
						//do nothing
					}
					num /= 10;
				}
				return true;
			}
		}
		public static void printSelfDividingNumbers(int x, int y)
		{
			try
			{
				if (x > y)
				{
					int a = x;
					x = y;
					y = a;
				}
				else
				{
					// do nothing
				}
				Console.WriteLine("Question 1\n");
				Console.WriteLine("The self-dividing number(s) between "+x.ToString()+" & "+ y.ToString()+" are:");
				while (x <= y)
				{
					if (isSelfDividing(x))
					{
						Console.Write(x.ToString() + " ");
					}						
					else
					{
						// do nothing
					}
					x++;	
				}
			}
			catch
			{
				Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
			}
		Console.WriteLine("\n\n\nQuestion 2\n");
		}
		public static void printSeries(int n)
		{
			/*
			* n – number of lines for the pattern, integer (int)
			* 
			* summary      : This method prints an inverted triangle using *
			* For example n = 5 will display the output as: 
			*********
			 *******
			  *****
			   ***
				*

			*
			* returns      : N/A
			* return type  : void
			*/
			Console.WriteLine("Inverted triangle series:\n");
			while (n > 0)
			{
				string invTri = new string('*', n);
				Console.WriteLine(invTri);
				n--;
			}

			Console.WriteLine("\n\nPlease press key to end program");
			Console.ReadKey(true);
		}
	}
}
