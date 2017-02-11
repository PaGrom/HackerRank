// https://www.hackerrank.com/challenges/flipping-the-matrix

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    private static int GetSol(int[][] mat, int n)
    {
        var sol = Enumerable.Range(0, n)
            .Select(r => MaxRow(mat, n, r).Sum())
            .Sum();

        return sol;
    }

    private static IEnumerable<int> MaxRow(int[][] mat, int n, int r)
    {
        return Enumerable.Range(0, n).Select(c => Items(mat, r, c, 2 * n).Max());
    }

    private static IEnumerable<int> Items(int[][] mat, int r, int c, int m)
    {
        var r2 = m - r - 1;
        var c2 = m - c - 1;

        return new [] {
            mat[r][c], mat[r][c2], mat[r2][c2], mat[r2][c]
        };
    }
    
    static void Main(String[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < q; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            var values = new string[2*n];
            for (int i = 0; i < n * 2; i++)
            {
                values[i] = Console.ReadLine();
            }
        
            int[][] m = new int[2*n][];
            
            for(int b0 = 0; b0 < n * 2; b0++)
            {
                m[b0] = Array.ConvertAll(values[b0].Split(null), Int32.Parse);
            }
            
            Console.WriteLine(GetSol(m, n));
        }
    }
}
