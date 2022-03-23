// https://leetcode.com/problems/cells-in-a-range-on-an-excel-sheet/

using System;

namespace CellsInRange
{
    public class Program 
    {
        private static void Main(string[] args) 
        {

			var res = CellsInRange("U7:X9");
			// var res2 = CellsInRange("A1:F1");

			foreach(string cell in res) 
			{
				Console.WriteLine(cell);
			}

			// foreach(var c in res2) {Console.WriteLine(c);}
        }

        public static List<string> CellsInRange(string s) 
        {
        	var result = new List<string>();

			string[] cells = s.Split(':');

        	string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			int firstRow = int.Parse(cells[0].Substring(1));
			int lastRow = int.Parse(cells[1].Substring(1));
			int firstCol = alpha.IndexOf(cells[0][0]);
			int lastCol = alpha.IndexOf(cells[1][0]);
			
			string columns = alpha.Substring(firstCol, lastCol - firstCol + 1);
			
			foreach(char c in columns) 
				for(int i = firstRow; i <= lastRow; i++)
					result.Add($"{c}{i}");
			
        	return result;
        }
    }
}
