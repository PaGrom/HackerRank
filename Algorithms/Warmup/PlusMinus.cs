// https://www.hackerrank.com/challenges/plus-minus

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        int pos = 0;
        int neg = 0;
        int zeros = 0;
        foreach (var i in arr)
        {
            if (i < 0)
            {
                neg++;
                continue;
            }
            if (i == 0)
            {
                zeros++;
                continue;
            }
            if (i > 0)
            {
                pos++;
            }
        }
        decimal g = (decimal)pos / n;
        Console.WriteLine(g.ToString("N6"));
        g = (decimal)neg / n;
        Console.WriteLine(g.ToString("N6"));
        g = (decimal)zeros / n;
        Console.WriteLine(g.ToString("N6"));
    }
}
