using System;
using System.Collections;
using System.Linq;

namespace SherlockAndAnagrams
{
    internal class Program
    {
        // link - https://www.hackerrank.com/challenges/sherlock-and-anagrams/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dictionaries-hashmaps
        private static int sherlockAndAnagrams(string s)
        {
            // ONLINE SOLUTION
            Hashtable table = new Hashtable();
            int count = 0;
            for (int i = 1; i < s.Length; i++)
            {
                for (int j = 0; j + i <= s.Length; j++)
                {
                    var subStr = s.Substring(j, i);
                    subStr = String.Concat(subStr.OrderBy(ch => ch));

                    if (table.Contains(subStr))
                    {
                        count += (int)table[subStr];
                        table[subStr] = (int)table[subStr] + 1;
                    }
                    else
                        table.Add(subStr, 1);
                }
            }

            return count;
            // MY SOLUTION (TOO SLOW)
            //Hashtable table = new Hashtable();

            //for (int i = 0; i < s.Length; i++)
            //{
            //    for (int k = 0; k < s.Length - i; k++)
            //    {
            //        var subStr = s.Substring(k, 1 + i);
            //        subStr = String.Concat(subStr.OrderBy(c => c));

            //        if (!table.Contains(subStr))
            //            table.Add(subStr, 0);

            //        for (int j = k + 1; j <= s.Length - subStr.Length; j++)
            //        {
            //            var cmprStr = s.Substring(j, subStr.Length);
            //            cmprStr = String.Concat(cmprStr.OrderBy(c => c));

            //            if (subStr == cmprStr)
            //                table[subStr] = (int)table[subStr] + 1;
            //        }
            //    }
            //}

            //int sum = table.Values.Cast<int>().Sum(x => x);
            //return sum;
        }

        private static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = sherlockAndAnagrams(s);

                Console.WriteLine(result);
            }
        }
    }
}