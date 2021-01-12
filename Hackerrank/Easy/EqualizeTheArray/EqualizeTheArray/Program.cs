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

namespace EqualizeTheArray
{
  class Program
  {
    static void Main(string[] args)
    {
      int n = Convert.ToInt32(Console.ReadLine());

      int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
      ;
      int result = equalizeArray(arr);

      Console.WriteLine(result);
    }

    static int equalizeArray(int[] arr)
    {
      int maxVal = 0;
      Hashtable table = new Hashtable();

      Array.ForEach(arr, x => 
      {
	if(!table.ContainsKey(x)) 
	  table.Add(x, 1);
	else 
	{
	  int val = (int)table[x];
	  table[x] = val + 1;
	}
      });

      foreach(var val in table.Values)
	if((int)val > maxVal) maxVal = (int)val;

      return arr.Length - maxVal;
    }
  }
}
