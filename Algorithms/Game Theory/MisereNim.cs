// https://www.hackerrank.com/challenges/misere-nim-1

using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine());
        for (int ni = 0; ni < n; ni++)
        {
            var p = Convert.ToInt32(Console.ReadLine());
            var xor = 0;
            var s = Console.ReadLine().Split(' ');
            var count = 0;
            for (int i = 0; i < p; i++)
            {
                var a = Convert.ToInt32(s[i]);
                xor ^= a;
                if (a <= 1)
                {
                    count++;
                }
            }
            if ((count == p && xor == 1) || (count < p && xor == 0))
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
