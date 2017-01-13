// https://www.hackerrank.com/challenges/compare-the-triplets

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        int A = 0;
        int B = 0;
        for (int i = 0; i < 3; i++)
        {
            var token_a = Convert.ToInt32(tokens_a0[i]);
            var token_b = Convert.ToInt32(tokens_b0[i]);
            if (token_a < token_b)
            {
                B++;
            }
            if (token_a > token_b)
            {
                A++;
            }
        }
        Console.WriteLine($"{A} {B}");
    }
}
