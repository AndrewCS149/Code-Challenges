using System;

namespace CatsAndAMouse
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/cats-and-a-mouse/problem
        private static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = catAndMouse(x, y, z);

                Console.WriteLine(result);
            }

            /*
            input -> 2, 3, 3
            output -> 'Cat B'

            input -> 2, 4, 3
            output -> 'Mouse C'
             */

            // Complete the catAndMouse function below.
            static string catAndMouse(int x, int y, int z)
            {
                int diffA = Math.Abs(x - z);
                int diffB = Math.Abs(y - z);

                if (diffA == diffB) return "Mouse C";

                return diffA < diffB ? "Cat A" : "Cat B";
            }
        }
    }
}