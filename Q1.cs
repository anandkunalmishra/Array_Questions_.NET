using System;
namespace Questions
{
    class Solution
    {
        public int[] freq = new int[101];
        public void countDuplicate(int[] arr)
        {
            for (int i = 0; i < this.freq.Length; i++)
            {
                freq[i] = 0;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                this.freq[arr[i]]++;
            }
        }

        public void printDuplicates(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (freq[arr[i]] > 1)
                {
                    Console.WriteLine($"The count of {arr[i]} is {this.freq[arr[i]]}");
                    freq[arr[i]] = 1;
                }
            }
        }
    }
    //class Problem
    //{
    //    public static void Main(String[] args)
    //    {
    //        Solution obj = new Solution();
    //        int num = Convert.ToInt32(Console.ReadLine());
    //        int[] arr = new int[num];
    //        for (int i = 0; i < num; i++)
    //        {
    //            arr[i] = Convert.ToInt32(Console.ReadLine());
    //        }

    //        obj.countDuplicate(arr);
    //        obj.printDuplicates(arr);

    //        Console.ReadLine();
    //    }
    //}
}