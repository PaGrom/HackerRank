// https://www.hackerrank.com/challenges/poker-nim-1

using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        var nt = Convert.ToInt32(Console.ReadLine());
        for (int ni = 0; ni < nt; ni++)
        {
            var t = Console.ReadLine().Split(' ');
            var n = Convert.ToInt32(t[0]);
            var k = Convert.ToInt32(t[1]);
            var xor = 0;
            var s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                xor ^= Convert.ToInt32(s[i]);
            }
            if (xor == 0)
            {
                Console.WriteLine("Second");
            }
            else
            {
                Console.WriteLine("First");
            }
        }
    }
}
