using System;
namespace Training_Day_9_
{
	public class Q3
	{
        public int[] freq = new int[101];
        public int[] arr = { 1, 2, 2, 3, 4, 4, 3, 4, 5, 6, 7, 8 };
        public void freqCount()
        {
            for (int i = 0; i < freq.Length; i++)
            {
                freq[i] = 0;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                freq[arr[i]]++;
            }
        }
    }
    //public class Problem
    //{
    //    public static void Main(String[] args)
    //    {
    //        Q3 obj = new Q3();
    //        obj.freqCount();

    //        for(int i = 0; i < obj.arr.Length; i++)
    //        {
    //            if (obj.freq[obj.arr[i]] >= 1)
    //            {
    //                Console.WriteLine($"The frequency of number {obj.arr[i]} is {obj.freq[obj.arr[i]]}");
    //                obj.freq[obj.arr[i]] = -1;
    //            }
    //        }

    //        Console.ReadLine();
    //    }
    //}
}

