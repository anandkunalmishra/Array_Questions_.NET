using System;
namespace Training_Day_9_
{
	public class Q7
	{
		public string reverseWord(string word)
		{
			char[] wordArray = word.ToCharArray();

			int Length = wordArray.Length;
			int middle = Length / 2;

			for(int i = 0; i < middle; i++)
			{
				char temp = word[i];
                wordArray[i] = word[Length - i - 1];
                wordArray[Length - i - 1] = temp;
			}
			return new string(wordArray);
		}
		public string reverseEachWord(string input)
		{
			string[] words = input.Split(' ');
			for(int i = 0; i < words.Length; i++)
			{
				words[i] = reverseWord(words[i]);
			}
            string newString = string.Join(" ", words);
			return newString;
		}
	}
	//public class Program
	//{
		
	//	public static void Main(String[] args)
	//	{
 //           Q7 obj = new Q7();
 //           string input = "Hello I am Anand";
 //           string output = obj.reverseEachWord(input);
	//		Console.WriteLine(output);
 //       }
		
	//}
}

