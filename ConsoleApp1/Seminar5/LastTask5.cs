using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_tasks.Seminar5
{
    internal class LastTask5
    {
        //Создайте метод, который принимает список чисел и функцию(делегат Func),
        //выполняющую какую-либо операцию над числами и возвращающую результат.

        public int Function(List<int> numders,Func<int,int,int > opiration, Predicate<int> iseven)
        {
            int summ = 0;
            foreach (int num in numders)
            {
                iseven(num);
                summ = opiration(num,summ);
            }
            return summ;

        }

    }
}
