// https://www.hackerrank.com/challenges/a-chessboard-game-1

using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        var t = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            var temp = Console.ReadLine().Split(' ');
            var x = Convert.ToInt32(temp[0]);
            var y = Convert.ToInt32(temp[1]);
            x %= 4;
            y %= 4;
            if (y == 0 || y==3 || x==0 || x==3)
            {
                Console.WriteLine("First");
            }
            else
            {
                Console.WriteLine("Second");
            }
        }
    }
}
