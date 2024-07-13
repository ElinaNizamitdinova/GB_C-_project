using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_tasks.Seminar2
{
    internal interface IMatrix<T>
    {
        T this[int row, int column] {  get; set; }
        void PrintMatrix();
    }
}
