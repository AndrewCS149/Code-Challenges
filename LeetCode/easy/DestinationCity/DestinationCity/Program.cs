using System;
using System.Collections.Generic;
using System.Linq;

namespace DestinationCity
{
    // link - https://leetcode.com/problems/destination-city/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string DestCity(IList<IList<string>> paths)
        {
            // MY SOLUTION
            /*var cities = new Dictionary<string, int>();

            for (int i = 0; i < paths.Count; i++)
            {
                for (int j = 0; j < paths[i].Count; j++)
                {
                    if (!cities.ContainsKey(paths[i][j]))
                        cities.Add(paths[i][j], 0);
                }
            }

            for (int i = 0; i < paths.Count; i++)
                cities[paths[i][0]] += 1;

            return cities.FirstOrDefault(x => x.Value == 0).Key;
            */

            //ONLINE SOLUTION
            var cities = new HashSet<string>();
            foreach (var list in paths)
                cities.Add(list[0]);

            foreach (var list in paths)
                if (cities.Add(list[1])) return list[1];

            return null;
        }
    }
}