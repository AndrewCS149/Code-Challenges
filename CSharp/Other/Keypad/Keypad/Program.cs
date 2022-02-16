using System;

namespace Keypad
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] nums = { 2, 3 };
            var res = Combinations(nums);

            foreach (string word in res)
                Console.WriteLine(word);
        }

        private static List<string> Combinations(int[] numbers)
        {
            var result = new List<string>();
            string[] map = { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

            Backtrack(result, numbers, "", 0, map);

            return result;
        }

        private static void Backtrack(List<string> result, int[] digits, string current, int idx, string[] map)
        {
            if (idx == digits.Length)
            {
                result.Add(current);
                return;
            }

            string letters = map[digits[idx]];
            for (int i = 0; i < letters.Length; i++)
            {
                Backtrack(result, digits, current + letters[i], idx + 1, map);
            }
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
