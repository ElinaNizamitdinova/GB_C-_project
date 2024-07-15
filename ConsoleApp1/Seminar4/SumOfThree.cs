using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_tasks.Seminar4
{
    public class SumOfThree
    {
        public void SummOfThree(List<int> list, int number)

        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < list.Count; i++)
            {
                {
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        int n = number - (list[j] + list[i]);
                        if (set.Contains(n) && (list[i]!=n && list[j] !=n))
                        {
                            Console.WriteLine($"Сумма чисел {list[i]},{list[j]},{n} равна {number}");
                        }
                        else
                        {
                            set.Add(list[i]);
                            set.Add(list[j]);
                        }
                    }
                }
            }
        }
    }
}
