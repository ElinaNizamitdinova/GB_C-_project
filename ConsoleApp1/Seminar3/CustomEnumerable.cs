using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_tasks.Seminar3
{
    internal class CustomEnumerable : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator() => new CostumEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
