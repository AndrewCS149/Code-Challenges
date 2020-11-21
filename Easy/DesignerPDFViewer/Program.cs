using System;

namespace DesignerPDFViewer
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
      ;
      string word = Console.ReadLine();

      int result = designerPdfViewer(h, word);

      Console.WriteLine(result);
    }

    static int designerPdfViewer(int[] h, string word)
    {
	int max = 0;
	foreach(char ch in word)
	{
	    for(int i = 0; i < h.Length; i++)
 	    {
		if((int)ch == 97 + i) 
		   if(h[i] > max) max = h[i];	
	    }
	}
	return max * word.Length;
    }
  }
}
