// https://www.hackerrank.com/challenges/icecream-parlor

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var t = Convert.ToInt32(Console.ReadLine());
        for (int ti = 0; ti < t; ti++)
        {
            var m = Convert.ToInt32(Console.ReadLine());
            var n = Convert.ToInt32(Console.ReadLine());
            var c = Console.ReadLine().Split(' ').Select(i => Convert.ToInt32(i)).ToArray();
            var flag = false;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (c[i] + c[j] == m)
                    {
                        Console.WriteLine($"{i+1} {j+1}");
                        flag = true;
                        break;
                    }
                }
                if (flag == true)
                {
                    break;
                }
            }
        }
    }
}
