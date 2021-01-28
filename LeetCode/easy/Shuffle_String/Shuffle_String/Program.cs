using System;
using System.Text;

namespace Shuffle_String
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(RestoreString("codeleet", new int[] { 4, 5, 6, 7, 0, 2, 1, 3 }));
            Console.WriteLine(RestoreString("abc", new int[] { 0, 1, 2 }));
            Console.WriteLine(RestoreString("aiohn", new int[] { 3, 1, 4, 2, 0 }));
        }

        public static string RestoreString(string s, int[] indices)
        {
            StringBuilder sb = new StringBuilder(s);

            for (int i = 0; i < indices.Length; i++)
                sb[indices[i]] = s[i];

            return sb.ToString();
        }
    }
}