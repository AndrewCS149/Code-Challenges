using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace CutTheSticks
{
  class Program
  {
    static void Main(string[] args)
    {
      int n = Convert.ToInt32(Console.ReadLine());

      int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
      ;
      int[] result = cutTheSticks(arr);

      Array.ForEach(result, x => Console.WriteLine(x));
    }

    static int[] cutTheSticks(int[] arr)
    {
	List<int> sticks = new List<int>();
	List<int> list = arr.OfType<int>().ToList();
	sticks.Add(arr.Length);
	
	while(list.Count > 0)
	{
	  int min = list.Where(x => x > 0).Min();
	  list = list.Select(x => x - min).ToList();
	  list.RemoveAll(x => x == 0);
	  if(list.Count <= 0) break;
	  sticks.Add(list.Count);
	}

	return sticks.ToArray();

    }
  }
}
