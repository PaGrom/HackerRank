// https://www.hackerrank.com/challenges/jim-and-the-orders

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution 
{
    static void Main(String[] args) 
    {
        var order = new List<KeyValuePair<int, int>>();
        var orders = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < orders; i++)
        {
            var details = Console.ReadLine().Split(' ').Select(c => Convert.ToInt32(c)).ToArray();
            order.Add(new KeyValuePair<int, int>(i + 1, details[0] + details[1]));
        }
        foreach(KeyValuePair<int, int> p in order.OrderBy(p => p.Value))
        {
            Console.Write(p.Key + " ");
        }
    }
}
