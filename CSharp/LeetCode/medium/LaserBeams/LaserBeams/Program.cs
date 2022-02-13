// https://leetcode.com/problems/number-of-laser-beams-in-a-bank/

using System;

namespace LaserBeams
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string[] test = { "011001", "000000", "010100", "001000" };
            Console.WriteLine(NumberOfBeams(test));
        }

        public static int NumberOfBeams(string[] bank)
        {
            if (bank.Length <= 1)
                return 0;

            int lasers = 0;
            int prevRow = bank[0].Count(x => x == '1');

            for (int i = 1; i < bank.Length; i++)
            {
                int curRow = bank[i].Count(x => x == '1');

                if (curRow > 0)
                {
                    lasers += (prevRow * curRow);
                    prevRow = curRow;
                }
            }

            return lasers;
        }
    }
}
