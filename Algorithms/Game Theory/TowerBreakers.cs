// https://www.hackerrank.com/challenges/tower-breakers-1

using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            var temp = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(temp[0]);
            int m = Convert.ToInt32(temp[1]);
            Console.WriteLine(m == 1 || n % 2 == 0 ? 2 : 1);
        }
    }
}
