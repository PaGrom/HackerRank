// https://www.hackerrank.com/challenges/sherlock-and-array

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var tests = Convert.ToInt32(Console.ReadLine());
        for (var ti = 0; ti < tests; ti++)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var arr = Console.ReadLine().Split(' ').Select(c => Convert.ToInt32(c)).ToArray();
            
            if (arr.Length == 1)
            {
                Console.WriteLine("YES");
                continue;
            }
            
            if (arr.Length < 3)
            {
                Console.WriteLine("NO");
                continue;
            }
            var left = arr[0];
            var rigth = arr.Sum() - arr[0] - arr[1];
            var flag = false;
            for (int i = 2; i < arr.Length; i++)
            {
                if (left == rigth)
                {
                    Console.WriteLine("YES");
                    flag = true;
                    break;
                }
                left += arr[i - 1];
                rigth -= arr[i];
            }
            if (!flag)
            {
                Console.WriteLine("NO");
            }
            
        }
    }
}
