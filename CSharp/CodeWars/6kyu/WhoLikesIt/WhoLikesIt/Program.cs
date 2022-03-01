// https://www.codewars.com/kata/5266876b8f4bf2da9b000362/train/csharp

using System;

namespace WhoLikesIt
{
    public class Program 
    {
        private static void Main(string[] args) 
        {
			Console.WriteLine(Liked(new string[]{}));
			Console.WriteLine(Liked(new string[]{"Peter"}));
			Console.WriteLine(Liked(new string[]{"Jacob", "Alex"}));
			Console.WriteLine(Liked(new string[]{"Max", "John", "Mark"}));
			Console.WriteLine(Liked(new string[]{"Alex", "Jacob", "Mark", "Max"}));
        }

        public static string Liked(string[] name) 
        {
        	if(name.Length == 0) 
        		return "no one likes this";
       		else if(name.Length == 1)
       			return $"{name[0]} likes this";
      		else if(name.Length == 2) 
      			return $"{name[0]} and {name[1]} like this";
			else if(name.Length == 3) 
				return $"{name[0]}, {name[1]} and {name[2]} like this";
			else 
				return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
        }
    }
}
