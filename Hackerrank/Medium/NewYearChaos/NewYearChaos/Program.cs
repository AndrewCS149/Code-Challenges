// https://www.hackerrank.com/challenges/new-year-chaos/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays

using System;
using System.Collections.Generic;

MinimumBribes(new List<int> { 1, 2, 5, 3, 7, 8, 6, 4 });
/*
 1, 2, 5, 3, 7, 8, 6, 4
 1, 2, 3, 5, 7, 8, 6, 4   1
 1, 2, 3, 5, 7, 6 8 4    2
 1 2 3 5 6 7 8 4       3
 1 2 3 5 6 7 4 8        4
 1 2 3 5 6 4 7 8        5
 1 2 3 5 4 6 7 8         6
 1 2 3 4 5 6 7 8        7
 
 
 */
static void MinimumBribes(List<int> q)
{
    int count = 0;

    for (int i = q.Count - 1; i >= 0; i--)
    {
        if (q[i] - (i + 1) > 2)
        {
            System.Console.WriteLine("Too chaotic");
            return;
        }

        for (int j = Math.Max(0, q[i] - 2); j < i; j++)
        {
            if (q[j] > q[i])
                count++;
        }
    }

    Console.WriteLine(count);
}
