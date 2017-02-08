// https://www.hackerrank.com/challenges/almost-sorted

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine());
        var ar = new int[n];
        var temp = Console.ReadLine().Split(' ');
        
        for (int i = 0; i < n; i++)
        {
            ar[i] = Convert.ToInt32(temp[i]);
        }
        
        var list = new List<int>();
        
        for (int i = 0; i < n - 1; i++)
        {
            if(ar[i] > ar[i + 1])
            {
                list.Add(i);
            }
        }
        
        int size = list.Count();
        if (size == 0)
        {
            Console.WriteLine("yes");
        }
        else if (size == 1)
        {
            if (n == 2)
            {
                Console.WriteLine("yes\nswap " + (list[0] + 1) + " " + (list[0] + 2));
            }
            else if (ar[list[0]] < ar[list[0] + 2] && ar[list[0] - 1] < ar[list[0] + 1])
            {
                Console.WriteLine("yes\nswap " + (list[0] + 1) + " " + (list[0] + 2));
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        else if (size == 2)
        {
            if (ar[list[0] - 1] < ar[list[1] + 1])
            {
                Console.WriteLine("yes\nswap " + (list[0] + 1) + " " + (list[1] + 2));
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        else if (list[size - 1] - list[0] + 1 == size)
        {
            Console.WriteLine("yes\nreverse " + (list[0] + 1) + " " + (list[size - 1] + 2));
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
