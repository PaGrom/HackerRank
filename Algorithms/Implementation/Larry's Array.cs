// https://www.hackerrank.com/challenges/larrys-array

using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int ti = 0; ti < t; ti++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var ar = new int[n];
            var temp = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                ar[i] = Convert.ToInt32(temp[i]);
            }
            int count = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ar[i] > ar[j])
                    {
                        count++;
                    }
                }
            }
            if (count % 2 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
