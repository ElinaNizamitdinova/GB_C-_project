using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_tasks.Seminar2
{
    internal interface IIndexable<T>
    {
        T this[int index] { get; set; }
    }
}
