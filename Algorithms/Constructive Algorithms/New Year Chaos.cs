// https://www.hackerrank.com/challenges/new-year-chaos

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        int T = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < T; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            string[] q_temp = Console.ReadLine().Split(' ');
            int[] q = Array.ConvertAll(q_temp, Int32.Parse);
            
            int ans = 0;
            bool chao = false;
            for (int i = n - 1; i >= 0; i--)
            {
                if (q[i] - (i + 1) > 2)
                {
                    Console.WriteLine("Too chaotic");
                    chao = true;
                    break;
                }
                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                {
                    if (q[j] > q[i])
                    {
                        ans++;
                    }
                }
            }
            if (!chao)
            {
                Console.WriteLine(ans);
            }
        }
    }
}
