using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    internal class Field
    {
        public int m { get; set; }
        public int n { get; set; }
        public int p { get; set; }
        public char[,] matrix { get; set; }

        public Field(int m, int n, int p)
        {
            this.m = m;
            this.n = n;
            matrix = new char[n, m];

            this.p = p;
        }
        private void fill()
        {
            Random rnd =  new Random();
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    int num = rnd.Next(100);
                    if(num <= p)
                    {
                        matrix[i, j] = '*';
                    }
                }
            }

            int count = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] != '*')
                    {
                        if (i == 0)
                        {
                            if (j == 0)
                            {

                            }
                        }

                    }
                }
            }

        }
    }
}
