// https://www.hackerrank.com/challenges/bomber-man

using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        var t = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(t[0]);
        int m = Convert.ToInt32(t[1]);
        int se = Convert.ToInt32(t[2]);
    
        if ( se > 4)
        {
            se = 4 + se % 4;
        }
        
        var ar = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            var s = Console.ReadLine();
            for (int j = 0; j < m; j++)
            {
                if (s[j] == '.')
                {
                    ar[i, j] = -1;
                }
                else
                {
                    ar[i, j] = 0;
                }
            }
        }

        for (int k = 2; k <= se; k++)
        {
            if (k % 2 == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (ar[i, j] == -1)
                        {
                            ar[i, j] = k;
                        }
                    }

                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (ar[i, j] == k - 3)
                        {
                            if (i - 1 >= 0 && ar[i-1, j] != k - 3)
                                ar[i - 1, j] = -1;
                            if (i + 1 < n && ar[i + 1, j] != k - 3)
                                ar[i + 1, j] = -1;
                            if (j + 1 < m && ar[i, j + 1] != k - 3)
                                ar[i, j + 1] = -1;
                            if (j - 1 >= 0 && ar[i, j - 1] != k - 3)
                                ar[i, j-1] = -1;
                            ar[i, j] = -1;
                        }
                    }
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (ar[i, j] == -1)
                    Console.Write(".");
                else
                    Console.Write("O");   
            }
            Console.WriteLine();
        }

    }
}
