// https://www.hackerrank.com/challenges/two-pluses

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    public class Cell
    {
        public int R;
        public int C;

        public Cell(int r, int c)
        {
            R = r;
            C = c;
        }

        public override bool Equals(object o)
        {
            if (this == o)
            {
                return true;
            }

            if (o == null || this.GetType() != o.GetType())
            {
                return false;
            }
            var cell = (Cell)o;
            if (R != cell.R)
            {
                return false;
            }
            return C == cell.C;
        }
    }

    public class Plus
    {
        public int R, C;
        public HashSet<Cell> Cells = new HashSet<Cell>();
        public bool[][] G;

        public Plus(int r, int c, bool[][] g)
        {
            R = r;
            C = c;
            Cells.Add(new Cell(r, c));
            G = g;
        }

        public int Size()
        {
            return Cells.Count();
        }

        public List<Plus> Grow()
        {
            var pluses = new List<Plus>();
            return Grow(0, pluses, this);
        }

        public List<Plus> Grow(int len, List<Plus> pluses, Plus last)
        {
            Plus clone = new Plus(R, C, G);
            clone.Cells = new HashSet<Cell>();
            clone.Cells.UnionWith(last.Cells);
            pluses.Add(clone);
            len++;
            if (R - len < 0
                    || C - len < 0
                    || R + len >= G.Length
                    || C + len >= G[0].Length)
                return pluses;
            if (!(G[R - len][C]
                    && G[R + len][C]
                    && G[R][C - len]
                    && G[R][C + len]))
                return pluses;
            Plus newP = last;
            newP.Cells.Add(new Cell((R - len), C));
            newP.Cells.Add(new Cell((R + len), C));
            newP.Cells.Add(new Cell(R, (C - len)));
            newP.Cells.Add(new Cell(R, (C + len)));
            pluses.Add(newP);
            return Grow(len, pluses, newP);
        }
    }

    private static bool isOverlapping(Plus p1, Plus p2)
    {
        foreach (var cell in p1.Cells)
        {
            foreach (var c in p2.Cells)
            {
                if (cell.Equals(c)) return true;
            }
        }
        return false;
    }

    static void Main(String[] args)
    {
        var temp = Console.ReadLine().Split(' ');
        int r = Convert.ToInt32(temp[0]);
        int c = Convert.ToInt32(temp[1]);
        bool[][] grid = new bool[r][];

        for (int i = 0; i < r; i++)
        {
            grid[i] = new bool[c];
            var s = Console.ReadLine();
            for (int j = 0; j < c; j++)
            {
                grid[i][j] = s[j] == 'G';
            }
        }
        var allPlusesSet = new HashSet<Plus>();
        for (int i = 1; i < r - 1; i++)
        {
            for (int j = 1; j < c - 1; j++)
            {
                var plus = new Plus(i, j, grid);
                var pluses = plus.Grow();
                allPlusesSet.UnionWith(pluses);
            }
        }
        var allPlusesList = new List<Plus>();
        allPlusesList.AddRange(allPlusesSet);
        int max = 0;
        for (int i = 0; i < allPlusesList.Count(); i++)
        {
            Plus plus = allPlusesList[i];
            for (int j = allPlusesList.Count() - 1; j > i; j--)
            {
                Plus p = allPlusesList[j];
                if (isOverlapping(plus, p))
                    continue;
                int product = plus.Size() * p.Size();
                if (product > max) max = product;
            }
        }
        Console.WriteLine(max);
    }
}
