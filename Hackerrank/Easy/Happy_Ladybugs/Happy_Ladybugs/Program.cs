using System;
using System.Collections;
using System.Linq;

namespace Happy_Ladybugs
{
    internal class Program
    {
        // link to challenge - https://www.hackerrank.com/challenges/happy-ladybugs/problem
        private static void Main(string[] args)
        {
            int g = Convert.ToInt32(Console.ReadLine());

            for (int gItr = 0; gItr < g; gItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                string b = Console.ReadLine();

                string result = happyLadybugs(b);

                Console.WriteLine(result);
            }
        }

        private static string happyLadybugs(string b)
        {
            // MY SOLUTION
            bool space = false;
            Hashtable table = new Hashtable();
            foreach (var ch in b)
            {
                if (ch == '_')
                {
                    space = true;
                    continue;
                }

                if (!table.ContainsKey(ch))
                    table.Add(ch, 1);
                else
                    table[ch] = (int)table[ch] + 1;
            }

            bool single = false;
            foreach (var val in table.Values)
                if ((int)val == 1) single = true;

            if (space == false && table.Count > 0 && single == false)
            {
                bool happy = true;
                int counter = 0;
                for (int i = 0; i < b.Length - 1; i++)
                {
                    if (b[i] == b[i + 1])
                        counter++;
                    else
                    {
                        if (counter == 0)
                        {
                            happy = false;
                            break;
                        }
                        else
                            counter = 0;
                    }
                }

                return happy ? "YES" : "NO";
            }

            return (space && !single) || (table.Count <= 1 && !single) ? "YES" : "NO";
        }
    }
}