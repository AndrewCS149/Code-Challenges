using System;

namespace SpecialStringAgain
{
    internal class Program
    {
        // link -  https://www.hackerrank.com/challenges/special-palindrome-again/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
	//
	// ONLINE SOLUTION
        private static long substrCount(int n, string s)
        {
            int count = n;
            for (int i = 0; i < n; i++)
            {
                int diffCharIdx = -1;
                char start = s[i];
                for (int k = i + 1; k < n; k++)
                {
                    char cur = s[k];
                    if (start == cur)
                    {
                        if (diffCharIdx == -1 || (k - diffCharIdx) == (diffCharIdx - i))
                            count++;
                    }
                    else
                    {
                        if (diffCharIdx == -1)
                            diffCharIdx = k;
                        else break;
                    }
                }
            }

            return count;
        }

        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            long result = substrCount(n, s);

            Console.WriteLine(result);
        }
    }
}
