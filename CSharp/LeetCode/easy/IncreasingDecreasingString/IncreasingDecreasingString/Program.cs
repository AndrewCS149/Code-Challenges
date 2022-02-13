using System;
using System.Linq;

namespace IncreasingDecreasingString
{
    // https://leetcode.com/problems/increasing-decreasing-string/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SortString("leetcode"));
        }

        public static string SortString(string s)
        {
            //string word = "";

            //while (s.Length > 0)
            //{
            //    for (int i = 0, j = 0; i < s.Length; i++, j++)
            //    {
            //        try
            //        {
            //            char max;
            //            if(j == 0)
            //                max = (from ch in s select ch).Min();
            //            else
            //                max = (from ch in s where ch > word[word.Length - 1] select ch).Min();

            //            word += max;
            //            s = s.Remove(s.IndexOf(word[word.Length - 1]), 1);
            //            i--;
            //        }
            //        catch (Exception)
            //        {
            //            break;
            //        }
            //    }

            //    for (int i = 0, j = 0; i < s.Length; i++, j++)
            //    {
            //        try
            //        {
            //            char min;
            //            if (j == 0)
            //                min = (from ch in s select ch).Max();
            //            else
            //                min = (from ch in s where ch < word[word.Length - 1] select ch).Max();

            //            word += min;
            //            s = s.Remove(s.IndexOf(word[word.Length - 1]), 1);
            //            i--;
            //        }
            //        catch (Exception)
            //        {
            //            break;
            //        }
            //    }
            //}

            //return word;

            // not my solution
            string word = "";
            int[] arr = new int[26];

            for (int i = 0; i < s.Length; i++)
                arr[s[i] - 'a']++;

            while(word.Length < s.Length)
            {
                for (int i = 0; i < 26; i++)
                    if(arr[i]-- > 0)
                        word += (char)(i + 'a');

                for (int i = 25; i >= 0; i--)
                    if (arr[i]-- > 0)
                        word += (char)(i + 'a');
            }

            return word;
        }
    }
}
