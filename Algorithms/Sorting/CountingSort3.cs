// https://www.hackerrank.com/challenges/countingsort3
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine());
        var array = new int[100];
        for (int i = 0; i < n; i++)
        {
            array[Convert.ToInt32(Console.ReadLine().Split(' ')[0])]++;
        }
        var prev = 0;
        for (var i = 0; i < 100; i++)
        {
            prev += array[i];
            Console.Write($"{prev} ");
        }
    }
}
