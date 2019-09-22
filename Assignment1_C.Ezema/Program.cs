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
			int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6 };
			int[] arr2 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
			int[] r5 = getLargestCommonSubArray(arr1, arr2);
			displayArray(r5);

			solvePuzzle();
			Console.WriteLine("\n\nPlease press key to end program");
			Console.ReadKey(true);
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

		public static void displayArray(int[] ans)
		{
			foreach (int element in ans)
			{
				Console.Write(element+" ");
			}
		}
		public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {
            try
            {
				/*
				* a – array of elements, integer (int)
				* 
				* summary      : This method finds the largest common contiguous subarray from two 
				* sorted arrays. The given arrays are sorted in ascending order. If there are multiple 
				* arrays with the same length, then return the last array having the maximum length.
				* The function should return the array.
				* For example:
				* a = [1,2,5,6,7,8,9], b = [1,2,3,4,5] will return the output: 
				* [1,2]
				* and
				* a = [1,2,3,4,5,6,7,8,9], b = [1,2,5,7,8,9,10] will return the output: 
				* [7,8,9]
				* and
				* a = [1,2,3,4,5,6], b = [1,2,5,6,7,8,9] will return the output: 
				* [5,6]
				*
				* returns      : Array of integers
				* return type  : int[]
				*/
				// Write your code here
				List<int> contSubArr = new List<int>();
				if (a.Length < 1 || b.Length < 1)
				{
					return new int[0];
				}
				else
				{
					for (int ai = 0; ai < a.Length; ai++)
					{
						int pNum = a[ai];
						for (int bi = 0; bi < b.Length; bi++)
						{
							if (pNum == b[bi]&& b.Contains(pNum+1))
							{
								contSubArr.Add(pNum);
							}
							else
							{
								//
							}
						}
					}
					for (int ti = 1; ti<contSubArr.Count;)
					{
						
						if (contSubArr[ti] - contSubArr[ti - 1] > 1)
						{
							contSubArr.RemoveAt(ti-1);
							ti = 1;
						}
						else
						{
							ti++;
						}
					}
					return contSubArr.ToArray();
				}
			}
			catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }

            return null; // return the actual array
        }

		public static string GetWords(string input, string input2, string output)
		{
			Console.Write("Type first word and press Enter: ");
			input = Console.ReadLine();
			Console.Write("Enter second word and Press Enter: ");
			input2 = Console.ReadLine();
			Console.Write("Enter output word and press Enter: ");
			output = Console.ReadLine();
			string texts = string.Format("{0}{1}{2}", input, input2, output);

			return texts;
		}
		// Taken from https://www.geeksforgeeks.org/numbers-unique-distinct-digits/ and modified for my needs here
		// Method to print unique digit numbers 
		// in range from l to r. 
		public static int [] UniqueNumber(int l, int r)
		{
			List<int> NumList = new List<int>();
			// Start traversing the numbers 
			for (int i = l; i <= r; i++)
			{
				int num = i;
				bool[] visited = new bool[10];

				// Find digits and maintain 
				// its hash 
				while (num != 0)
				{

					// if a digit occcurs more 
					// than 1 time then break 
					if (visited[num % 10])
						break;

					visited[num % 10] = true;

					num = num / 10;
				}

				// num will be 0 only when 
				// above loop doesn't get 
				// break that means the number 
				// is unique so print it. 
				if (num == 0)
				{
					NumList.Add(i);
				}
					
			}
			return NumList.ToArray();
		}

		//taken from https://stackoverflow.com/questions/829174/is-there-an-easy-way-to-turn-an-int-into-an-array-of-ints-of-each-digit
		public static int[] NumbersIn(int value)
		{
			var numbers = new Stack<int>();

			for (; value > 0; value /= 10)
				numbers.Push(value % 10);

			return numbers.ToArray();
		}
		public static void solvePuzzle() 
        {
            try 
            {
				// Write your code here
				/*use maximal organization of your
				* code into the appropriate methods(e.g.a method to collect inputs, a method to
				* identify unique characters in the strings, a method to test the currently assigned
				* values etc).*/


				string words =(GetWords(Console.ReadLine(), Console.ReadLine(), Console.ReadLine()));
				string answer = new String(words.Distinct().ToArray());
				int l = 100000000, r = 999999999;
				int[] AlphatoNum = UniqueNumber(l, r);
				int[] test = new int[] { };
				foreach (int element in AlphatoNum)
				{
					int [] digits = NumbersIn(element);
					int U = digits[0];
					int B = digits[1];
					int E = digits[2];
					int R = digits[3];
					int C = digits[4];
					int O = digits[5];
					int L = digits[6];
					int N = digits[7];

					int UBER = int.Parse(U.ToString() + B.ToString()+ E.ToString() + R.ToString());
					int COOL = int.Parse(C.ToString() + O.ToString() + O.ToString() + L.ToString());
					int UNCLE = int.Parse(U.ToString() + N.ToString() + C.ToString() + L.ToString() + E.ToString());

					if ((UBER + COOL) == UNCLE)
					{
						Console.Write(UBER.ToString()+" "+ COOL.ToString()+"= " +UNCLE.ToString());
						break;
					}
				}

				Console.WriteLine("\n\nPlease press key to end program");
				Console.ReadKey(true);
				/*for (int i = 0; i < answer.Length;i++)
				{
				
				}*/
			}
			catch
            {
                Console.WriteLine("Exception occured while computing solvePuzzle()");
            }
        }
    }
} 