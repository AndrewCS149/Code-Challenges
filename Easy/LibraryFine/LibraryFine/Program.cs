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
namespace LibraryFine
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] d1M1Y1 = Console.ReadLine().Split(' ');

      int d1 = Convert.ToInt32(d1M1Y1[0]);

      int m1 = Convert.ToInt32(d1M1Y1[1]);

      int y1 = Convert.ToInt32(d1M1Y1[2]);

      string[] d2M2Y2 = Console.ReadLine().Split(' ');

      int d2 = Convert.ToInt32(d2M2Y2[0]);

      int m2 = Convert.ToInt32(d2M2Y2[1]);

      int y2 = Convert.ToInt32(d2M2Y2[2]);

      int result = libraryFine(d1, m1, y1, d2, m2, y2);

      Console.WriteLine(result);
    }

    static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
    {
      int fine = 0;

      if (y1 < y2) return fine;
      else if (y1 == y2)
      {
        if (m1 < m2) return fine;
        else if (m1 == m2)
        {
          if (d1 > d2) fine = (d1 - d2) * 15;
        }
        if (m2 < m1) fine = (m1 - m2) * 500;
      }
      else fine = 10000;

      return fine;
    }
  }
}
