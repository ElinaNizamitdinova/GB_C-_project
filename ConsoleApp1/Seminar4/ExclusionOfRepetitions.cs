using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_tasks.Seminar4
{
    public class ExclusionOfRepetitions
    {
        //Дан список целых чисел(числа не последовательны), в котором некоторые числа повторяются.
        //Выведите список чисел на экран, исключив из него повторы.Постарайтесь сделать задачу за O(N)
        
        public void NoRepetitions(List<int> ints)
        {
           // var set1 = new HashSet<int>();
           List<int > noRepetitions = new List<int>();
            foreach(var item in ints)
            {
                if (!noRepetitions.Any(x => x == item))
                {
                    noRepetitions.Add(item);
                }
            }
            foreach(int i in noRepetitions)
            {
                Console.WriteLine(i);
            }
               // set1.Add(ints[i]);
        }
          

    }


}

 