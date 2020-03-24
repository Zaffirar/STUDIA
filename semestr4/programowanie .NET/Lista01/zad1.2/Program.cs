using System;

namespace zad1._2
{
    class Grid
    {
        private int[,] tab;
        private int a, b;
        public Grid(int a, int b)
        {
            this.a = a;
            this.b = b;
            tab = new int[a, b];
        }
        public int[] this[int j]
        {
            get
            {
                int[] row = new int[b];
                for(int i=0; i < b; i++)
                {
                    row[i] = tab[j, i];
                }
                return row;
            }
        }
        public int this[int x, int z]
        {
            set
            {
                tab[x, z] = value;
            }
            get
            {
                return tab[x, z];
            }
        }

    }
    class Program
    {
        static void Main()
        {
            Grid grid = new Grid(3, 3);
            grid[0, 0] = 0;
            grid[0, 1] = 1;
            grid[0, 2] = 2;
            grid[1, 0] = 3;
            grid[1, 1] = 4;
            grid[1, 2] = 5;
            grid[2, 0] = 6;
            grid[2, 1] = 7;
            grid[2, 2] = 8;
            int[] rowdata = grid[1];
            foreach(int i in rowdata)
            {
                Console.Write(i.ToString() + " ");
            }
            int elem = grid[2, 2];
            Console.WriteLine(elem.ToString());
        }
    }
}
