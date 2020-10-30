using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Migratory_Birds
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/migratory-birds/problem
        private static void Main(string[] args)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = migratoryBirds(arr);

            Console.WriteLine(result);
        }

        private static int migratoryBirds(List<int> arr)
        {
            arr.Sort();
            arr.Reverse();

            int count = 1;
            int[] newArr = new int[arr.Count()];
            newArr[0] = count;
            int num = arr[0];
            for (int i = 1; i < arr.Count(); i++)
            {
                if (arr[i] == num)
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                newArr[i] = count;
                num = arr[i];
            }

            int newNum = newArr[0];
            int idx = 0;
            for (int i = 0; i < newArr.Length; i++)
            {
                if (newArr[i] > newNum)
                {
                    newNum = newArr[i];
                    idx = i;
                }
            }

            foreach (var item in arr)
            {
                Console.Write(item + ", ");
            }

            return arr[idx];

            //Array.ForEach(newArr, x => Console.Write(x + ", "));

            //Console.WriteLine();

            //return 1;
        }
    }
}