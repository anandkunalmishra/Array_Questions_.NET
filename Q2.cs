using System;
namespace Training_Day_9_
{
    public class Q2
    {
        // Write a program in C# Sharp to print all unique elements in an array.
        int[] arr = { 1, 2, 2, 2, 3, 4, 5, 8, 6 };

        public void sort(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            } 
        }

        public List<int> removeDuplicate()
        {
            List<int> uniqueArray = new List<int>();
            sort(arr);
            for(int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    uniqueArray.Add(arr[i]);
                }
            }
            uniqueArray.Add(arr[arr.Length - 1]);
            return uniqueArray;
        }
        
    }
    //public class Program
    //{
    //    static Q2 obj = new Q2();
    //    public static void Main(String[] args)
    //    {
    //        List<int> resultArray = obj.removeDuplicate();

    //        foreach (var item in resultArray)
    //        {
    //            Console.Write($"{item} ");
    //        }

    //        Console.ReadLine();
    //    }
    //}
}

