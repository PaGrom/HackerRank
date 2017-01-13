// https://www.hackerrank.com/challenges/diagonal-difference

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
        }
        long fDiagonal = 0;
        long sDiagonal = 0;
        for (int i = 0; i < n; i++){
            fDiagonal += a[i][i];
        }
        for (int i = 0; i < n; i++){
            int j = n - 1 - i;
            sDiagonal += a[i][j];
        }
        var diff = Math.Abs(fDiagonal - sDiagonal);
        Console.WriteLine(diff);
    }
}
