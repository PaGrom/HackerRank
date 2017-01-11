// https://www.hackerrank.com/challenges/closest-numbers 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine());
        var arr = Console.ReadLine().Split(' ').Select(i => Convert.ToInt32(i)).ToArray();
        Array.Sort(arr);
        var min = int.MaxValue;
        var answ = new List<Tuple<int, int>>();
        for (int i = 1; i < n; i++)
        {
            var diff = arr[i] - arr[i-1];
            if (diff > min)
            {
                continue;
            }
            if (diff == min)
            {
                answ.Add(new Tuple<int, int>(arr[i-1], arr[i]));
                continue;
            }
            if (diff < min)
            {
                min = diff;
                answ.Clear();
                answ.Add(new Tuple<int, int>(arr[i-1], arr[i]));
            }
        }
        answ.ForEach(t => Console.Write($"{t.Item1} {t.Item2} "));
    }
}
