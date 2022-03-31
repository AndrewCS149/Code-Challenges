//  https://www.codewars.com/kata/550f22f4d758534c1100025a/train/csharp

using System;

namespace DirectionsReduced
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var res1 = dirReduc(new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" });
            foreach (var i in res1) Console.Write(i + " ");
        }

        public static string[] dirReduc(string[] arr)
        {
            var path = arr.ToList();

            for (int i = 0; i < path.Count - 1; i++)
            {
                string cur = path[i] + path[i + 1];
                if (cur == "NORTHSOUTH" || cur == "SOUTHNORTH" ||
                    cur == "WESTEAST" || cur == "EASTWEST")
                {
                    path.RemoveRange(i, 2);
                    i = -1;
                }
            }

            return path.ToArray();
        }

        /*

        
		W
		 
		


		

        */
    }
}

