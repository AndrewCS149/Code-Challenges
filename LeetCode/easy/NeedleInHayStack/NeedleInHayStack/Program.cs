using System;

namespace NeedleInHayStack
{
    class Program
    {
        // https://leetcode.com/explore/featured/card/top-interview-questions-easy/127/strings/885/
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int StrStr(string haystack, string needle)
        {
            if (haystack == "" && needle == "") return 0;
            for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                string tmp = haystack.Substring(i, needle.Length);
                Console.WriteLine("TMP " + tmp);

                if (tmp == "" && needle == "")
                    break;

                if (tmp == needle)
                    return i;
            }

            return -1;
        }
    }
}
