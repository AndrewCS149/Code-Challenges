using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ClimbingTheLeaderBoard
{
    internal class Program
    {
        // Link - https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static List<int> ClimbingTheLeaderboard(List<int> ranked, List<int> player)
        {
            List<int> uniqueRanked = ranked.Distinct<int>().ToList<int>();
            List<int> places = new List<int>();
            for (int i = uniqueRanked.Count; i > 0; i--)
            {
                foreach (var item in player)
                {
                    if (item < uniqueRanked[i])
                    {
                        places.Add(++i);
                    }
                }
            }
        }
    }
}