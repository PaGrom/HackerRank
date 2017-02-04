// https://www.hackerrank.com/challenges/nimble-game-1

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
            for (int i = 1; i < p; i++)
            {
                var a = Convert.ToInt32(s[i]);
                var c = 0;
                if (a % 2 == 0)
                {
                    c = 0;
                }
                else
                {
                    c = i;
                }
                xor ^= c;
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
