// https://www.hackerrank.com/challenges/sherlock-and-the-beast

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            var m = n;
            while (m % 3 != 0)
            {
                m -= 5;
                if (m < 0)
                {
                    Console.WriteLine(-1);
                    break;
                }
            }
            if (m >= 0)
            {
                for (int i = 0; i < m; i++)
                {
                    Console.Write(5);
                }
                for (int i = 0; i < n-m; i++)
                {
                    Console.Write(3);
                }
                Console.WriteLine();
            }
        }
    }
}

