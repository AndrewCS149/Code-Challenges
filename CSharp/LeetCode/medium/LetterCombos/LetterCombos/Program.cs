// https://leetcode.com/problems/letter-combinations-of-a-phone-number/
using System;

namespace LetterCombos
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var result = LetterCombinations("23");
            Console.WriteLine(result.Count);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
        }

        public static IList<string> LetterCombinations(string digits)
        {
            // EXTREMELY UGLY
            var combos = new List<string>();

            if (digits.Length == 0)
                return combos;

            string[] map = { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

            int[] idxs = Array.ConvertAll(digits.ToCharArray(), c => (int)Char.GetNumericValue(c));

            string letters1 = map[idxs[0]];
            for (int i = 0; i < letters1.Length; i++)
            {
                string combo = letters1[i].ToString();
                if (idxs.Length > 1)
                {
                    string letters2 = map[idxs[1]];
                    for (int j = 0; j < letters2.Length; j++)
                    {
                        combo = letters1[i].ToString() + letters2[j].ToString();

                        if (idxs.Length > 2)
                        {
                            string letters3 = map[idxs[2]];
                            for (int k = 0; k < letters3.Length; k++)
                            {
                                combo = letters1[i].ToString() + letters2[j].ToString() + letters3[k].ToString();

                                if (idxs.Length > 3)
                                {
                                    string letters4 = map[idxs[3]];
                                    for (int m = 0; m < letters4.Length; m++)
                                    {
                                        combo += letters4[m];
                                        combos.Add(combo);
                                        combo = letters1[i].ToString() + letters2[j].ToString() + letters3[k].ToString();
                                    }
                                }
                                else
                                {
                                    combos.Add(combo);
                                    combo = letters1[i].ToString() + letters2[j].ToString();
                                }
                            }
                        }
                        else
                            combos.Add(combo);
                    }
                }
                else
                {
                    combos.Add(letters1[i].ToString());
                }
            }

            return combos;
        }
    }
}
