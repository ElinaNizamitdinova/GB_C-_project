using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_tasks.Seminar4
{
    internal class LastTask
    {
        public void Format() 
        {
            List<String> strings = new List<String>();
            strings.Add("Катя");
            strings.Add("Оля");
            strings.Add("Маша");
            strings.Add("Валя");
            strings.Add("Ира");

            string str = "ля";
            var result = strings.Where(s => s.ToUpper().Contains(str.ToUpper()));
            Console.WriteLine(string.Join(",", result).ToUpper());
        }
    }
}
