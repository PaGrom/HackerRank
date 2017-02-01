// https://www.hackerrank.com/challenges/nim-game-1

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
            for (int i = 0; i < p; i++)
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
