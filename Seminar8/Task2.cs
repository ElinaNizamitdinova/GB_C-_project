using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar8
{
    internal class Task2
    {
        private static List<string> SearchIn(string Path, string name)
        {
            var list = new List<string>();
            DirectoryInfo dir = new DirectoryInfo(Path);
            var directories = dir.GetDirectories();
            var fils = dir.GetFiles();
            foreach (var item in fils)
            {
                if (item.Name.Contains(name))
                {
                    list.Add(item.Name);
                }
                if (item.Extension.Contains(name))
                {
                    list.Add((string)item.Name);
                }
            }
            foreach (var item in directories)
            {
                list.AddRange(SearchIn(item.FullName, name));
            }

            return list;
        }
    }
}
