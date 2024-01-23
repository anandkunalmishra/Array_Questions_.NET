using System;
namespace Training_Day_9_
{
	public class Q8
	{
		public int sumEachDigit(int num)
		{
			int sum = 0;
			while (num>0)
			{
				int rem = num % 10;
				sum += rem;
				num /= 10;
			}
			return sum;
		}
	}
	public class Program
	{
		public static void Main()
		{
			Q8 obj = new Q8();
			int num = 1234567898;
			int result = obj.sumEachDigit(num);

			Console.WriteLine($"The sum of each digit of {num} is {result}");

			Console.ReadLine();

		}
	}
}

