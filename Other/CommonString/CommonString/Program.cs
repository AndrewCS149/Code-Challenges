using System;
using System.Collections.Generic;
using System.Linq;

namespace CommonString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string str = "It was fun. I had more fun that I ever have.";
            string str2 = "the water was great. the movies were great. parks are great";
            var res = MostCommonString(str, 2);
            var res2 = MostCommonString(str2, 2);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            foreach (var item in res2)
            {
                Console.WriteLine(item);
            }
        }

        public static Dictionary<string, int> MostCommonString(string str, int n)
        {
            str = str.Replace(".", "").ToLower();
            string[] arr = str.Split(" ");

            var dict = new Dictionary<string, int>();
            foreach (string item in arr)
            {
                if (!dict.ContainsKey(item))
                    dict.Add(item, 1);
                else
                    dict[item] = dict[item] + 1;
            }

            var result = dict.OrderByDescending(x => x.Value).Take(n);
            return result.ToDictionary(x => x.Key, x => x.Value);
        }
    }
}