// https://www.hackerrank.com/challenges/game-of-stones-1

using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var t = Convert.ToInt32(Console.ReadLine());
            if (t % 7 < 2)
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
