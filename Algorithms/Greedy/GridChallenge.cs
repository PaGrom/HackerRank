// https://www.hackerrank.com/challenges/grid-challenge

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{    
    public static bool IsListSorted(List<char> list)
    {
        var oldList = new List<char>(list);
        var newList = new List<char>(list);
        newList.Sort();
        return oldList.SequenceEqual(newList);
    }
    
    static void Main(String[] args)
    {
        var tests = Convert.ToInt32(Console.ReadLine());
        for (int ti = 0; ti < tests; ti++)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var grid = new List<List<char>>();
            for (int i = 0; i < n; i++)
            {
                var row = Console.ReadLine().ToList();
                row.Sort();
                grid.Add(row);
            }
            
            var isSorted = true;
            
            for (int i = 0; i < n; i++)
            {
                var column = new List<char>();
                for (int j = 0; j < n; j++)
                {
                    column.Add(grid[j][i]);
                }
                if (!IsListSorted(column))
                {
                    isSorted = false;
                    break;
                }
            }
            if (isSorted)
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
