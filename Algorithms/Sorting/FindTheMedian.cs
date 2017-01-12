// https://www.hackerrank.com/challenges/find-the-median

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        var arr = Console.ReadLine().Split(' ').Select(i => Convert.ToInt32(i)).ToArray();
        Array.Sort(arr);
        var mid = arr[arr.Length / 2];
        Console.WriteLine(mid);
    }
}
