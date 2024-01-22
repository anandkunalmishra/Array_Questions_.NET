using System;
namespace Training_Day_9_
{
	public class Q4
	{
		public void minmax(int[] arr)
		{
			int min = int.MaxValue;
			int max = int.MinValue;

			for (int i = 0; i < arr.Length; i++)
			{
				if (max < arr[i]) max = arr[i];
				if (min > arr[i]) min = arr[i];
            }

            Console.WriteLine($"The max value is {max}");
            Console.WriteLine($"The min value is {min}");
        }
	}
	public class Program
	{
		static Q4 obj = new Q4();
		public static void Main(String[] args)
		{
			int[] arr = { 1, 4, 6, 7, 2, 5 };
            obj.minmax(arr);
            Console.ReadLine();
        }

		
	}
}

