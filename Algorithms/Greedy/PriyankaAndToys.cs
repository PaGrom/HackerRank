// https://www.hackerrank.com/challenges/priyanka-and-toys

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine());
        var w = Console.ReadLine().Split(' ').Select(c => Convert.ToInt32(c)).ToArray();
        Array.Sort(w);
        var count = 1;
        var t = w[0];
        for (int i = 1; i < n; i++)
        {
            if (w[i] > t + 4)
            {
                t = w[i];
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

