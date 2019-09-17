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

			int n3 = 5;
			printTriangle(n3);


			Console.WriteLine("\n\nQuestion 4\n\nJewels Count:");
			int[] J = new int[] { 1, 3 };
			int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
			int r4 = numJewelsInStones(J, S);
			Console.WriteLine(r4);

			Console.WriteLine("\n\nQuestion 5\n\nLargest Common Array:");
			int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
			int[] arr2 = new int[] { 1, 2, 3, 4, 5 };
			int[] r5 = getLargestCommonSubArray(arr1, arr2);
			Console.WriteLine(r5);
			Console.WriteLine("\n\nPlease press key to end program");
			Console.ReadKey(true);

			solvePuzzle();
		}
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
				// Write your code here
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
				Console.WriteLine("The self-dividing number(s) between " + x.ToString() + " & " + y.ToString() + " :");
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
        }

        public static void printSeries(int n)
        {
            try
            {
				// Write your code here
				Console.WriteLine("\n\n\nQuestion 2\n");
				/*
				* n – number of terms of the series, integer (int)
				* 
				* summary        : This method prints the following series till n terms:
				* 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6, 6 …. n terms
				* For example, if n = 5, output will be
				* 1, 2, 2, 3, 3
				*
				* returns        : N/A
				* return type    : void
				*/
				Console.WriteLine("Print series:\n");
				string ans = "";
				int i = 1;
				while (ans.Length < n)
				{
					string a = i.ToString();
					string t1 = new string(char.Parse(a), i);
					ans = ans + t1;
					i++;
				}
				if (ans.Length > n)
				{
					int rem = ans.Length - n;
					ans = ans.Substring(0, ans.Length - rem);
				}
				else
				{
					//;
				}
				Console.Write(ans);
			}
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }

        public static void printTriangle(int n)
        {
            try
            {
				// Write your code here
				Console.WriteLine("\n\n\nQuestion 3\n");
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
			}
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static int numJewelsInStones(int[] J, int[] S)
        {
            try
            {
				/*
				* a – array of elements, integer (int)
				* 
				* summary      : You're given an array J representing the types of stones that are 
				* jewels, and S representing the stones you have.  Each element in S is a type of 
				* stone you have.  You want to know how many of the stones you have are also jewels.
				* The elements in J are guaranteed distinct.
				* The function should return an integer.
				* For example:
				* J = [1,3], S = [1,3,3,2,2,2,2,2] will return the output: 
				* 3 (since 1, 3, 3 are jewels)
				* and
				* J = [2], S = [0,0] will return the output: 
				* 0
				*
				* returns      : Integer
				* return type  : int
				*/

				// Write your code here
				int count = 0;
				foreach (int stone in S)
				{
					if (J.Contains(stone))
					{
						count++;
					}
					else
					{
						//
					}
				}
				return count;
			}
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }

            return 0;
        }

        public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }

            return null; // return the actual array
        }

        public static void solvePuzzle() 
        {
            try 
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing solvePuzzle()");
            }
        }
    }
} 