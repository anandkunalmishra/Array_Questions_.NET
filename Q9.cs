using System;
namespace Training_Day_9_
{
	public class Q9
	{
		public List<int> sumMatrixEachRow(int[][] matrix) 
		{
			List<int> result = new List<int>();

			for (int i = 0; i < matrix.Length; i++)
			{
				int sum = 0;
				for (int j = 0; j < matrix[0].Length; j++)
				{
					sum += matrix[i][j];
				}
				result.Add(sum);
			}
			return result;
		}
	}
	public class Program
	{

        /*
         * 
		 * matrix looks like
		 * 
		 *  1 2 3 4 5
		 *  6 7 8 9 10
		 *  11 12 13 14 15
		 *  16 17 18 19 20
		 *  21 22 23 24 25
		 *  
		 *  printing looks like 
		 *  
		 *  row1 = sum row1
		 *  row2 = sum row2
		 *  row3 = sum row3
		 *  row4 = sum row4
		 *  row5 = sum row5
		 *  
		 */

		public static void Main(string[] args)
		{
			Q9 obj = new Q9();
			int[][] matrix = {
				new int[]{ 1,2,3,4,5},
				new int[]{6,7,8,9,10},
				new int[]{11,12,13,14,15},
				new int[]{16,17,18,19,20},
				new int[]{21,22,23,24,25}
			};
			List<int> values = obj.sumMatrixEachRow (matrix);
			for(int i = 0; i < values.Count; i++)
			{
				Console.WriteLine($"The sum of {i + 1} row is {values[i]}");
			}
		}

    }
}

