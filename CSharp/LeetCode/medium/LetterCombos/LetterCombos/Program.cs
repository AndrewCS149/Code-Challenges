// https://leetcode.com/problems/letter-combinations-of-a-phone-number/
using System;

namespace LetterCombos
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var result = LetterCombinations("23");
            foreach (var item in result)
            {
            Console.WriteLine(item);
            }
        }

		private static List<string> LetterCombinations(string digits, List<string> result = null, string current = "", int idx = 0) 
		{
			if(result == null) 
				result = new List<string>();

			if(digits == "") 
				return result;

			if(current.Length == digits.Length) 
			{
				result.Add(current);
				return result;
			}

			string[] map = {"", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};
			string letters = map[(int)char.GetNumericValue(digits[idx])];

			for(int i = 0; i < letters.Length; i++) 
				LetterCombinations(digits, result, current + letters[i], idx + 1);

			return result;
		}
    }
}
