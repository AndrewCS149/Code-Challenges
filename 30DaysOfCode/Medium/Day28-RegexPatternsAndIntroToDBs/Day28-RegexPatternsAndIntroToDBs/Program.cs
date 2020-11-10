using System;
using System.Collections;
using System.Collections.Generic;

namespace Day28_RegexPatternsAndIntroToDBs
{
    internal class Program
    {
        // medium
        // link to challenge - https://www.hackerrank.com/challenges/30-regex-patterns/problem?utm_campaign=30_days_of_code_continuous&utm_medium=email&utm_source=daily_reminder

        private static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            List<string> accounts = new List<string>();

            for (int NItr = 0; NItr < N; NItr++)
            {
                string[] firstNameEmailID = Console.ReadLine().Split(' ');

                string firstName = firstNameEmailID[0];

                string emailID = firstNameEmailID[1];

                if (emailID.EndsWith("@gmail.com"))
                    accounts.Add(firstName);
            }

            accounts.Sort();
            accounts.ForEach(x => Console.WriteLine(x));
        }
    }
}