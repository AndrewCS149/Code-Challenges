using System;

namespace Bigger_Is_Greater
{
    internal class Program
    {
        // link to challenge-  https://www.hackerrank.com/challenges/bigger-is-greater/problem
        private static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());

            for (int TItr = 0; TItr < T; TItr++)
            {
                string w = Console.ReadLine();

                string result = biggerIsGreater(w);

                Console.WriteLine(result);
            }
        }

        private static string biggerIsGreater(string w)
        {
            // NOT MY SOLUTION
            char[] arr = w.ToCharArray();

            int i = arr.Length - 1;
            while (i > 0 && arr[i - 1] >= arr[i]) i--;

            if (i <= 0) return "no answer";

            int j = arr.Length - 1;
            while (arr[j] <= arr[i - 1]) j--;

            char tmp = arr[i - 1];
            arr[i - 1] = arr[j];
            arr[j] = tmp;

            j = arr.Length - 1;
            while (i < j)
            {
                tmp = arr[i];
                arr[i++] = arr[j];
                arr[j--] = tmp;
            }

            return new string(arr);
        }
    }
}