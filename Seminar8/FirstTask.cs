using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar8
{
    internal class FirstTask
    {   //  for Main
        //foreach(var item in args)
        //{
        //    Console.WriteLine(item);
        //};
        //string str = ReadFrom(args[0]);
        //WriteTo(str, args[1]);
        private static void WriteTo(string str, string path)
        {

            using (FileStream fs = new FileStream(path, FileMode.CreateNew))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(str);
                }
            }

        }

        private static string ReadFrom(string path)
        {
            StreamReader sr = new StreamReader(path);
            return sr.ReadToEnd();
        }
    }
}
