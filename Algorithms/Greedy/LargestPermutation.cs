// https://www.hackerrank.com/challenges/largest-permutation

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var t = Console.ReadLine().Trim().Split(' ');
        var n = Convert.ToInt32(t[0]);
        var k = Convert.ToInt32(t[1]); 
        var arr = Console.ReadLine().Trim().Split(' ').Select(c => Convert.ToInt32(c)).ToArray();
        var j = 0;
        
        for(int i = 0; i < n; i++)
        {
            if(arr[i] != n - i && k != 0)
            {
                j = i + 1;
                while (arr[j] != n - i)
                {
                    j++;
                }
                var temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                k--;
            }
        }

        for(int i= 0; i < n; i++)
        {
            Console.Write($"{arr[i]} ");
        }
        
    }
}
