using System;

namespace CanSumTabulation
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(CanConstruct(7, new int[] { 2, 3 }));
            Console.WriteLine(CanConstruct(7, new int[] { 5, 2, 4, 7 }));
            Console.WriteLine(CanConstruct(7, new int[] { 2, 4 }));
            Console.WriteLine(CanConstruct(8, new int[] { 2, 3, 5 }));
            Console.WriteLine(CanConstruct(300, new int[] { 7, 14 }));
        }

        public static bool CanConstruct(int target, int[] numbers)
        {
            bool[] table = new bool[target + 1];
            table[0] = true;

            for (int i = 0; i <= target; i++)
            {
                if (table[i])
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (i + numbers[j] < table.Length)
                            table[i + numbers[j]] = true;
                    }
                }
            }

            return table[target];
        }
    }
}
