﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafiosCSharp.Piramide
{
    public class Piramide
    {
        private int _n;
        public int N
        {
            get { return _n; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("N deve ser maior ou igual a 1.");
                }
                _n = value;
            }
        }

        public Piramide(int n)
        {
            N = n;
        }

        public void Desenha()
        {
            for (int i = 1; i <= N; i++)
            {

                for (int j = 0; j < N - i; j++)
                {
                    Console.Write(" ");
                }


                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }


                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
        }
    }
}