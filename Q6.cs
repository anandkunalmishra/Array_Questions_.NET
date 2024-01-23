using System;
namespace Training_Day_9_
{
	public class Q6
	{
		public void printPattern(int num)
		{
			for (int i = 0; i < num; i++)
			{
				for(int j = 0; j < num; j++)
				{
					if(i==0 || i==num-1 || j==0 || j == num-1)
					{
						Console.Write("* ");
					}
					else
					{
						Console.Write("  ");
					}
				}
				Console.Write("\n");
			}
		}
	}
	public class Program
	{
		static Q6 obj = new Q6();
		public static void Main(String[] args)
		{
			int num = 8;
			obj.printPattern(num);
		}
	}
}

