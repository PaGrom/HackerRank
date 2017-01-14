// https://www.hackerrank.com/challenges/missing-numbers

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{    
    static Dictionary<int, int> Freq(int[] arr)
    {
        var freq = new Dictionary<int, int>();
        foreach(var i in arr)
        {
            if (freq.Keys.Contains(i))
            {
                freq[i]++;
            }
            else
            {
                freq[i] = 0;
            }
        }
        
        return freq;
    }
    
    static void Main(String[] args)
    {
        var a = Convert.ToInt32(Console.ReadLine());
        var a_arr = Console.ReadLine().Split(' ').Select(i => Convert.ToInt32(i)).ToArray();
        var b = Convert.ToInt32(Console.ReadLine());
        var b_arr = Console.ReadLine().Split(' ').Select(i => Convert.ToInt32(i)).ToArray();
        
        var frA = Freq(a_arr);
        var frB = Freq(b_arr);
        var answ = new List<int>();
        foreach (var i in new HashSet<int>(b_arr))
        {
            if (!frA.Keys.Contains(i))
            {
                answ.Add(i);
                continue;
            }
            
            var diff = frB[i] - frA[i];
            
            if (diff > 0)
            {
                answ.Add(i);
            }
        }
        answ.Sort();
        foreach (var i in answ)
        {
            Console.Write($"{i} ");
        }
    }
}