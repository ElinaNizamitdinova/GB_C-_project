﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_tasks.Seminar2
{
    internal class Matrix<T> : IMatrix<T>
    {
        private T[,] arr;
        public Matrix(int row, int column)
        {
            arr = new T[row, column];
        }
        public T this[int row, int column]
        { get => arr[row, column];
            set => arr[row, column] = value;

        }



        public void PrintMatrix()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

