using System;
using System.Collections;
using System.Collections.Generic;

namespace SalesByMatch
{
    internal class Program
    {
        // easy
        // link to challenge https://www.hackerrank.com/challenges/sock-merchant/problem
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);

            Console.WriteLine(result);
        }

        // Complete the sockMerchant function below.
        private static int sockMerchant(int n, int[] ar)
        {
            Hashtable table = new Hashtable();
            int count = 0;

            foreach (var item in ar)
            {
                if (table.ContainsKey(item))
                    table[item] = (int)table[item] + 1;
                else
                    table.Add(item, 1);

                if (table[item].Equals(2))
                {
                    count++;
                    table[item] = 0;
                }
            }
            return count;
        }

        // input -> 2, 2, 4, 5, 5
        // output -> 2

        // edge cases
        // zero socks
        // all integers

        /*
        VAR count = 0
        HASHSET hSet
        FOR i IN arr
            IF hSet CONTAINS i
                INCRIMENT i VALUE
                IF VALUE == 2
                    INCRIMENT count
                    VALUE = 0
            ELSE
                ADD i KEY VALUE

        RETURN count
         */
    }
}