using System;
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

namespace JumpingOnTheClouds
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] nk = Console.ReadLine().Split(' ');

      int n = Convert.ToInt32(nk[0]);

      int k = Convert.ToInt32(nk[1]);

      int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
      ;
      int result = jumpingOnClouds(c, k);

      Console.WriteLine(result);
    }

    /*
       I did not come up with this solution. I it was derived from the discussions within this challenges forum. 
    */
    static int jumpingOnClouds(int[] c, int k)
    {
      int energy = 100;
      int idx = 0;

      while (true)
      {
        idx = (idx + k) % c.Length;
        if (c[idx] == 1) energy -= 3;
        else energy--;

        if (idx == 0) break;
      }
      return energy;
    }
  }
}
