// https://www.hackerrank.com/challenges/mark-and-toys

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var t = Console.ReadLine().Split(' ');
        var n = Convert.ToInt32(t[0]);
        var k = Convert.ToInt32(t[1]);
        var p = Console.ReadLine().Split(' ').Select(c => Convert.ToInt32(c)).ToList();
        p.Sort();
        var count = 0;
        var sum = 0;
        for (int i = 0; i < n; i++)
        {
            if (sum > k)
            {
                break;
            }
            sum += p[i];
            count++;
        }
        Console.WriteLine(--count);
    }
}
