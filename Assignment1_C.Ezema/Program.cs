/*
    Author: Chukwuebuka Ezema
    Date: 9/15/2019
    Comments: This C# Console application code is used to solve all six questions for Assignment 1 
*/

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
			// Display title as the C# console calculator app.
			Console.WriteLine("ISM6225 Assignment 1 C#\r");
			Console.WriteLine("------------------------\n");

			// Ask the user to choose an option.
			Console.WriteLine("Choose an option from the following list:");
			Console.WriteLine("\t1 - Self Dividing Number");
			Console.WriteLine("\t2 - Series");
			Console.WriteLine("\t3 - Triangle");
			Console.WriteLine("\t4 - Jewels in Stones");
			Console.WriteLine("\t5 - Largest Common Sub Array");
			Console.WriteLine("\t6 - Uber, Cool, Uncle");
			Console.Write("Your selection? ");

			// Use a switch statement to run user selection.
			switch (Console.ReadLine())
			{
				case "1":
					//Explain self dividing to the user
					Console.WriteLine("\n\n\tSummary: This finds all the self dividing numbers between user specified range\n\n");
					int fnum = 0; int snum2 = 0;
					// Ask the user to type the first number.
					while (true)
					{
						try
						{
							Console.WriteLine("Enter the first number in the range, and then press Enter");
							fnum = int.Parse(Console.ReadLine());
						}
						catch
						{
							Console.Write("\nYou must enter a whole number.\n");
							continue;
						}
						break;
					}
					// Ask the user to type the second number.
					while (true)
					{
						try
						{
							Console.WriteLine("Enter second number, and then press Enter");
							snum2 = int.Parse(Console.ReadLine());
						}
						catch
						{
							Console.Write("\nYou must enter a whole number.\n");
							continue;
						}
						break;
					}
					printSelfDividingNumbers(fnum, snum2);
					break;
				case "2":
					//Explain Print Series to the user
					Console.WriteLine(
							"\n\n\tSummary: This prints the following series till n terms: \n " +
							"\t1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5, 6, 6 …. n terms\n\n" +
							"\tFor example, if n = 5, output will be:\n\n" +
							"\t[1, 2, 2, 3, 3]\n\n");
					int series = 0;
					// Ask the user to type the n terms and verify its a number not string.
					while (true)
					{
						try
						{
							Console.WriteLine("Type the n terms for the series, and then press Enter");
							series = int.Parse(Console.ReadLine());
						}
						catch
						{
							Console.Write("\nYou must enter a whole number.\n");
							continue;
						}
						break;
					}
					printSeries(series);
					break;
				case "3":
					//Explain Print Triangle to the user
					Console.WriteLine(
						"\n\n\tSummary: This prints an inverted triangle using *\n" +
						"\tFor example n = 5 will display the output as: \n\n" +
						"\t	*********	\n" +
						"\t	 *******	\n" +
						"\t	  *****	\n" +
						"\t	   ***	\n" +
						"\t\t    *	");
					int tri = 0;
					// Ask the user to type the n number and verify that they entered a number not a string.
					while (true)
					{
						try
						{
							Console.WriteLine("Type the number n for inverted triangle, and then press Enter");
							tri = int.Parse(Console.ReadLine());
						}
						catch
						{
							Console.Write("\nYou must enter a whole number.\n");
							continue;
						}
						break;
					}
					printTriangle(tri);
					break;
				case "4":
					//Explain Print Jewels in Stones to the user
					Console.WriteLine(
						"\n\n\tSummary: You're given an array J representing the types of stones that are jewels, " +
						"\n\tand S representing the stones you have." +
						"\tEach element in S is a type of stone you have.\n" +
						"\tYou want to know how many of the stones you have are also jewels." +
						" The elements in J are guaranteed distinct.\n" +
						"\tFor Example: \n" +
						"\tJ = [1, 3], S = [1, 3, 3, 2, 2, 2, 2, 2] will return the output:\n" +
						"\t3(since 1, 3, 3 are jewels)\n" +
						"\tand\n" +
						"\tJ = [2], S = [0, 0] will return the output:\n" +
						"\t0\n\n");
					Console.WriteLine("\t This program will run\n " +
						"\tJ = {1,3}\n" +
						"\tS = {1, 3, 3, 2, 2, 2, 2, 2}\n\n");
					Console.WriteLine("Press any key to continue...");
					Console.ReadKey(true);

					int[] Jewels = new int[] { 1, 3 };
					int[] Stones = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
					int JS = numJewelsInStones(Jewels, Stones);
					Console.WriteLine("\n\n\tAns: ");
					Console.WriteLine("\tCount of Stones in Jewels = {0}",JS);
					break;
				case "5":

					//Explain get largest common sub array to the user
					Console.WriteLine(
						"\n\n\tSummary: This method finds the largest common contiguous subarray from two sorted arrays.\n" +
						"\tThe given arrays are sorted in ascending order. If there are multiple arrays with the same length,\n" +
						"\tthen return the last array having the maximum length.\n" +
						"\tFor example:\n" +
						"\ta = [1, 2, 5, 6, 7, 8, 9], b = [1, 2, 3, 4, 5] will return the output:\n" +
						"\t[1, 2]\n" +
						"\tand\n" +
						"\ta = [1, 2, 3, 4, 5, 6, 7, 8, 9], b = [1, 2, 5, 7, 8, 9, 10] will return the output:\n" +
						"\t[7, 8, 9]\n" +
						"\tand\n" +
						"\ta = [1, 2, 3, 4, 5, 6], b = [1, 2, 5, 6, 7, 8, 9] will return the output:\n" +
						"\t[5, 6]\n");

					//Set that the program will run. 
					int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
					int[] arr2 = new int[] { 1, 2, 5, 7, 8, 9, 10 };

					//Informing user the set that the program will run
					Console.WriteLine("\t\nThis program will run\n " +
						"\tFirst Set = "+ string.Join(",", arr1) +
						"\n\tSecond Set = " + string.Join(",", arr2));
					Console.WriteLine("\n\nPress any key to continue...");
					Console.ReadKey(true);
					
					int[] r5 = getLargestCommonSubArray(arr1, arr2);
					Console.WriteLine("\n\nAns: ");
					displayArray(r5);
					break;
				case "6":


					solvePuzzle();
					break;
			}
			// Wait for the user to respond before closing.
			Console.WriteLine("\n\n ");
			Console.WriteLine("Press any key to close the Assignment app...");
			Console.ReadKey();
		}
		//method to find if number is self dividing
		static bool isSelfDividing(int n)
		{
			// initialize the number n 
			int num = n;

			//convert to a string for processing
			string alphanum = n.ToString();
			
			// check if the number contains zero, if it does it, it's not self dividing
			if (alphanum.Contains('0'))
			{
				return false;
			}
			// if it does not contain zero process each digit to see if it is self dividing
			else
			{
				// Checking each digit by dividing the number by 10 and using the reminder
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
		
		//This is method for printing self dividing numbers between two numbers
		public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {
				// Write your code here
				// Check to make sure that the larger number is second
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
				Console.WriteLine("\n\n");
				Console.WriteLine("The self-dividing number(s) between " + x.ToString() + " & " + y.ToString() + " :\n");
				
				// Check each number until we reach the max number (y)
				while (x <= y)
				{
					//Check if current number is self dividing
					if (isSelfDividing(x))
					{
						//Print if number is self dividing
						Console.Write(x.ToString() + " ");
					}
					else
					{
						// do nothing
					}
					// next number 
					x++;
				}
			}
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }
		
		//This method print the number series up to n terms 
        public static void printSeries(int n)
        {
            try
            {
				// Write your code here
				//initialize a blank string to hold the series and initialize an integer = 0
				string ans = "";
				int i = 1;
				
				//Loop until ans string length is equal to the n term entered by user
				while (ans.Length < n)
				{
					//Convert integer to string
					string a = i.ToString();
					//creating a string t1 of numbers by duplicating each number based on its value
					string t1 = new string(char.Parse(a), i);
					//adding that string to initialized ans string
					ans = ans + t1;
					//next number
					i++;
				}
				//this is to remove any extra characters to make sure we return n terms
				if (ans.Length > n)
				{
					//initialize an integer rem to find the number of characters to remove
					int rem = ans.Length - n;
					//remove all extra characters
					ans = ans.Substring(0, ans.Length - rem);
				}
				else
				{
					// do nothing;
				}
				// Displays the answer
				Console.WriteLine("\n\nAns: ");
				foreach (char c in ans)
				{
					Console.Write(c+" ");
				}
				
			}
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }

		//This method prints a triangle of n stars and height
        public static void printTriangle(int n)
        {
            try
            {
				// Write your code here
				//Will print * from n series down until 1
				while (n > 0)
				{
					//Prints n '*' terms for that line
					string invTri = new string('*', n);
					Console.WriteLine(invTri);

					//minus 1 from n and loop
					n--;
				}
			}
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

		//This method checks the number of stones that are jewels
        public static int numJewelsInStones(int[] J, int[] S)
        {
			// Initialize an int count to track how many stones are also jewels 
			int count = 0;
            try
            {
				// Write your code here


				//Checking each jewel to see if it's also in stone
				for(int j = 0; j < J.Length; j++)
				{
					int jewel = J[j];
					for (int s = 0; s < S.Length; s++)
					{
						int stone = S[s];
						//if stone is in jewel add 1 to the count
						if (jewel==stone)
						{
							count++;
						}
					}
				}
				//return the final count
				return count;
			}
            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }
			return count;
        }
		
		//This method displays the elements of the largest common sub array
		public static void displayArray(int[] ans)
		{
			//display the elements of the ans array
			foreach (int element in ans)
			{
				Console.Write(element+" ");
			}
		}

		//This method finds the largest common array from two arrays
		public static int[] getLargestCommonSubArray(int[] a, int[] b)
        {				
			//initialize a blank list array to hold all the common number
			List<int> contSubArr = new List<int>();
            try
            {
				// Write your code here

				//if any of the inputs array is empty return a blank answer
				if (a.Length < 1 || b.Length < 1)
				{
					return new int[0];
				}
				else
				{
					//Checking for common values in both arrays
					for (int ai = 0; ai < a.Length; ai++)
					{
						int pNum = a[ai];
						for (int bi = 0; bi < b.Length; bi++)
						{
							//If the second array contains the current number and the next number + 1 then add to the list array
							if (pNum == b[bi]&& b.Contains(pNum+1))
							{
								//add to list array
								contSubArr.Add(pNum);
							}
							else
							{
								// do nothing
							}
						}
					}

					//Find the contigous array values in list
					for (int ti = 1; ti<contSubArr.Count;)
					{
						//Difference greater than 1 then remove number from list and loop through list
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
				}
			}
			catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }
			//return final result to be used by the displayArray method
			return contSubArr.ToArray();
		}

		//This asks the user for the words Uber, Cool and Uncle
		static string GetWords()
		{
			//Ask user for input of Uber, Cool, Uncle
			Console.WriteLine("Enter Uber, and then press Enter");
			string uber = Console.ReadLine();
			Console.WriteLine("Enter Cool, and then press Enter");
			string cool = Console.ReadLine();
			Console.WriteLine("Enter Uncle, and then press Enter");
			string uncle = Console.ReadLine();
			string texts = string.Format("{0}{1}{2}", uber, cool, uncle);
			
			//return string from user
			return texts;
		}
		
		// This method was source from https://www.geeksforgeeks.org/numbers-unique-distinct-digits/ and modified for my needs
		// Method to find unique digit numbers from range l - r
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

		//This method was sourced from https://stackoverflow.com/questions/829174/is-there-an-easy-way-to-turn-an-int-into-an-array-of-ints-of-each-digit
		//used to convert the unique number string to an array of digits
		public static int[] NumbersIn(int value)
		{
			//initialized a blank collection
			var numbers = new Stack<int>();

			//enumerating through value and adding each digit to the collection
			for (; value > 0; value /= 10)
				numbers.Push(value % 10);

			//return number to be used to solution
			return numbers.ToArray();
		}

		// This method is used to solve the uber+cool = uncle 
		public static void solvePuzzle() 
        {
            try 
            {
				// Write your code here
				//get user input of uber , cool and uncle

				string words = GetWords();

				// get the distinct characters
				string answer = new String(words.Distinct().ToArray());
				
				//set range for distinct numerical values used 8 since there are 8 distinct characters
				int l = 100000000, r = 999999999;

				//Letting user know code engine is currently processing
				Console.WriteLine("Processing...");

				//Get all the unique values between 10000000 and 999999999
				int[] AlphatoNum = UniqueNumber(l, r);

				//Check which combination of numbers will create uber+cool=uncle
				foreach (int element in AlphatoNum)
				{
					//get the individual digits of each unique number
					int [] digits = NumbersIn(element);

					//Assign a value to the unique letters of Uber, Cool, Uncle
					int U = digits[0];
					int B = digits[1];
					int E = digits[2];
					int R = digits[3];
					int C = digits[4];
					int O = digits[5];
					int L = digits[6];
					int N = digits[7];

					//Creating a numerical value for the word UBER, COOL and UNCLE
					int UBER = int.Parse(U.ToString() + B.ToString()+ E.ToString() + R.ToString());
					int COOL = int.Parse(C.ToString() + O.ToString() + O.ToString() + L.ToString());
					int UNCLE = int.Parse(U.ToString() + N.ToString() + C.ToString() + L.ToString() + E.ToString());

					//Check if the combination for Uber+Cool=UNCLE exists
					if ((UBER + COOL) == UNCLE)
					{
						//Display the numbers that make up UBER + COOL = UNCLE
						Console.WriteLine("\n\nAns: \n\n");
						Console.Write("\tThe numbers that make up UBER+ COOL = UNCLE are: \n\t"+UBER.ToString()+" + "+ COOL.ToString()+"= " +UNCLE.ToString());
						break;
					}
				}
			}
			catch
            {
                Console.WriteLine("Exception occured while computing solvePuzzle()");
            }
        }
    }
} 