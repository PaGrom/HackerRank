// https://www.hackerrank.com/challenges/countingsort2
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine());
        var l = Console.ReadLine().Split(' ').Select(c => Convert.ToInt32(c));
        var array = new int[l.Max()+1];
        foreach (var a in l)
        {
            array[Convert.ToInt32(a)]++;
        }
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < array[i]; j++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
