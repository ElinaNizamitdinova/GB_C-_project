using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_tasks.Seminar3
{
    internal class FindPath
    {
         public int FindPathMethod(int i, int j, int[,] labirynth1)
        {
            Stack<Tuple<int, int>> _path = new Stack<Tuple<int, int>>();
            int count = 0;

            if (labirynth1[i, j] == 0) _path.Push(new(i, j));

            while (_path.Count > 0)
            {
                var current = _path.Pop();


                if (labirynth1[current.Item1, current.Item2] == 2)
                {
                    Console.WriteLine($"Найден путь {current.Item1},{current.Item2} ");
                    count++;
                }

                labirynth1[current.Item1, current.Item2] = 1;

                if (current.Item1 + 1 < labirynth1.GetLength(0)
                && labirynth1[current.Item1 + 1, current.Item2] != 1)
                    _path.Push(new(current.Item1 + 1, current.Item2));

                if (current.Item2 + 1 < labirynth1.GetLength(1) &&
                labirynth1[current.Item1, current.Item2 + 1] != 1)
                    _path.Push(new(current.Item1, current.Item2 + 1));

                if (current.Item1 > 0 && labirynth1[current.Item1 - 1, current.Item2] != 1)
                    _path.Push(new(current.Item1 - 1, current.Item2));

                if (current.Item2 > 0 && labirynth1[current.Item1, current.Item2 - 1] != 1)
                    _path.Push(new(current.Item1, current.Item2 - 1));
            }

            return count;

        }
    }
}
