// https://www.codewars.com/kata/541c8630095125aba6000c00/train/csharp

using System;

namespace SumOfDigits
{
    public class Program 
    {
        private static void Main(string[] args) 
        {
			Console.WriteLine(DigitalRoot(16));
			Console.WriteLine(DigitalRoot(942));
			Console.WriteLine(DigitalRoot(132189));
			Console.WriteLine(DigitalRoot(493193));
        }

        public static int DigitalRoot(long n) 
        {
        	while(n >= 10) 
        	{
        		long tmp = 0;
        		while(n > 0) 
        		{
        			tmp += (n % 10);
        			n /= 10;
        		}
        		n = tmp;
        	}

        	return (int)n;
        }
    }
}
