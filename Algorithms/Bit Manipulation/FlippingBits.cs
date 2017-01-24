// https://www.hackerrank.com/challenges/flipping-bits

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
            uint t = uint.Parse(Console.ReadLine());
            Console.WriteLine($"{~t}");
        }
    }
}
