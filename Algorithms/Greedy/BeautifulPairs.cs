// https://www.hackerrank.com/challenges/beautiful-pairs

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine());
        var a = Console.ReadLine().Split(' ').Select(c => Convert.ToInt32(c)).ToArray();
        var b = Console.ReadLine().Split(' ').Select(c => Convert.ToInt32(c)).ToArray();
        
        var count = 0;
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (b[j] > 0)
                {
                    if (a[i] == b[j])
                    {
                        count++;
                        b[j] *= -1;
                        break;
                    }
                }
            }
        }
        
        if (count == n)
        {
            Console.WriteLine(count - 1);
        }
        else
        {
            Console.WriteLine(count + 1);
        }
    }
}
