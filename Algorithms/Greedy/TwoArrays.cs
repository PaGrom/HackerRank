// https://www.hackerrank.com/challenges/two-arrays

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var test = Convert.ToInt32(Console.ReadLine());
        for (int ti = 0; ti < test; ti++)
        {
            var t = Console.ReadLine().Split(' ').Select(c => Convert.ToInt32(c)).ToArray();
            var n = t[0];
            var k = t[1];
            var a = Console.ReadLine().Split(' ').Select(c => Convert.ToInt32(c)).ToArray();
            var b = Console.ReadLine().Split(' ').Select(c => Convert.ToInt32(c)).ToArray();
            Array.Sort(a);
            Array.Sort(b);
            var flag = true;
            for (int i = 0; i < n; i++)
            {
                if (a[i] + b [n - 1 - i] < k)
                {
                    Console.WriteLine("NO");
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("YES");
            }
        }
    }
}
