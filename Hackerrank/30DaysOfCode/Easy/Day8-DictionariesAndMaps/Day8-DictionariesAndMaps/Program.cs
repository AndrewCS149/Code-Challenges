using System;
using System.Collections.Generic;

namespace Day8_DictionariesAndMaps
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/30-dictionaries-and-maps/problem
        private static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            int entries = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < entries; i++)
            {
                string entry = Console.ReadLine();
                string[] splitEntry = entry.Split(' ');
                phoneBook.Add(splitEntry[0], splitEntry[1]);
            }

            string name;
            while ((name = Console.ReadLine()) != null)
            {
                bool exists = phoneBook.TryGetValue(name, out string phoneNum);
                if (exists)
                    Console.WriteLine($"{name}={phoneNum}");
                else
                    Console.WriteLine("Not found");
            }
        }
    }
}