using System;
namespace Training_Day_9_
{
	public class Q5
	{
		public void printPattern(int num)
		{
			for (int i = 0; i < num; i++) 
			{
				for(int j = num; j>i; j--)
				{
					Console.Write("* ");
				}
				Console.Write("\n");
			}
		}
	}
	public class Program
	{
		static Q5 obj = new Q5();
		public static int num = 8;
		public static void Main(String[] args)
		{
			obj.printPattern(num);

		}
	}
}

