using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_tasks.Seminar4
{
    public class Increasing
    {
        //Дан список целых чисел(числа не последовательны), в котором некоторые числа повторяются.
        //Выведите список чисел на экран, расположив их в порядке возрастания частоты повторения


        //Модифицируйте код предыдущей задачи таким образом чтобы вывод элементов был в порядке убывания частоты их повторения

        public void Task1(List<int> ints)
        {

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < ints.Count; i++)
            {
                if (dict.ContainsKey(ints[i]))
                {
                    dict[ints[i]]++;
                }

                else
                {
                    dict[ints[i]] = 1;
                }

            }
            PriorityQueue<int,int> priorityQueue = new PriorityQueue<int,int>();
            foreach (var element in dict)
            {

                priorityQueue.Enqueue(element.Key, element.Value * -1);
                    
            }
            while (priorityQueue.Count > 0)
            {
                Console.WriteLine(priorityQueue.Dequeue());
            }

        }
    }
}