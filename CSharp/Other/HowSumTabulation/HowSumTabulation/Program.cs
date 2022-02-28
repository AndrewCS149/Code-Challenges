using System;

namespace HowSumTabulation
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var result = HowSum(7, new int[] { 2, 3 });
            var result2 = HowSum(7, new int[] { 5, 3, 4, 7 });
            var result3 = HowSum(7, new int[] { 2, 4 });
            var result4 = HowSum(8, new int[] { 2, 3, 5 });
            var result5 = HowSum(300, new int[] { 7, 14 });

            foreach (int n in result) Console.Write(n + ", ");
            Console.WriteLine();
            foreach (int n in result2) Console.Write(n + ", ");
            Console.WriteLine();

            foreach (int n in result3) Console.Write(n + ", ");
            Console.WriteLine();

            foreach (int n in result4) Console.Write(n + ", ");
            Console.WriteLine();

            foreach (int n in result5) Console.Write(n + ", ");
        }

        public static List<int> HowSum(int target, int[] numbers)
        {
            var result = new List<int>[target + 1];
            result[0] = new List<int>();

            for (int i = 0; i <= target; i++)
            {
                if (result[i] != null)
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (i + numbers[j] < result.Length)
                        {
                            result[i + numbers[j]] = new List<int>(result[i]);
                            result[i + numbers[j]].Add(numbers[j]);
                        }
                    }
                }
            }


            return result[result.Length - 1];
        }
    }
}
