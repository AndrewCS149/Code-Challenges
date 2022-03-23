// https://leetcode.com/problems/single-row-keyboard/

using System;

namespace SingleRowKeyboard
{
    public class Program 
    {
        private static void Main(string[] args) 
        {
			Console.WriteLine(CalculateTime("abcdefghijklmnopqrstuvwxyz", "cba"));
			Console.WriteLine(CalculateTime("pqrstuvwxyzabcdefghijklmno", "leetcode"));
        }

        public static int CalculateTime(string keyboard, string word) 
        {
        	int count = keyboard.IndexOf(word[0]);

			for(int i = 0; i < word.Length - 1; i++) 
				count += Math.Abs(keyboard.IndexOf(word[i]) - keyboard.IndexOf(word[i + 1]));

        	return count;
        }
    }
}
