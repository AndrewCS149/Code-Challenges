// https://leetcode.com/problems/letter-combinations-of-a-phone-number/submissions/

using System;

namespace Keypad
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //var res = Combinations(new int[] { 2, 3 });
            var res = Combinations2("23");


            foreach (string word in res)
                Console.WriteLine(word);
        }

        private static List<string> Combinations(string numbers)
        {
            var result = new List<string>();
            string[] map = { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

            Backtrack(result, numbers, "", 0, map);

            return result;
        }

        private static void Backtrack(List<string> result, string digits, string current, int idx, string[] map)
        {
            if (idx == digits.Length)
            {
                result.Add(current);
                return;
            }

            string letters = map[(int)char.GetNumericValue(digits[idx])];
            for (int i = 0; i < letters.Length; i++)
                Backtrack(result, digits, current + letters[i], idx + 1, map);
        }

        //private static List<string> Combinations2(string digits, List<string> result = null, string current = "", int idx = 0)
        //{
        //    if (result == null)
        //        result = new List<string>();

        //    if (digits.Length == current.Length)
        //    {
        //        result.Add(current);
        //        return result;
        //    }

        //    string[] map = { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

        //    string letters = map[(int)char.GetNumericValue(digits[idx])];
        //    for (int i = 0; i < letters.Length; i++)
        //        Combinations2(digits, result, current + letters[i], idx + 1);

        //    return result;
        //}

        private static List<string> Combinations2(string digits, List<string> result = null, string current = "", int idx = 0)
        {
            if (result == null)
                result = new List<string>();

            if (digits == "")
                return result;

            if (digits.Length == current.Length)
            {
                result.Add(current);
                return result;
            }

            string[] map = { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            string letters = map[(int)char.GetNumericValue(digits[idx])];

            for (int i = 0; i < letters.Length; i++)
                Combinations2(digits, result, current + letters[i], idx + 1);

            return result;
        }
    }
}


/*
  1    2    3
      abc  def
  4    5    6
 ghi  jkl  mno 
  7    8    9
 pqrs tuv  wxyz
       0

*/
