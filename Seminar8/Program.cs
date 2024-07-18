


using System.ComponentModel.DataAnnotations;

namespace Seminar8
{
    internal class Program
    {
        const string path = "Program.cs";
        const string word = "list";

        static void Main(string[] args)
        {
            var text = ReadFrom(path);
            var filter = Filter(word,text); 
            foreach (string item in args)
            {
                Console.WriteLine(item);
            };
            List<string> list = SearchIn(path: args[0], name: args[1]);
            List<string> result = new List<string>();
            foreach (var item in list ) {

                if (filter.Contains(item))
                {
                    result.Add(item);
                }
            }
            Console.WriteLine(String.Join("\n", result)+"is result");
            

        }
        static List<string> Filter(string word, List<string> text)
        {
            return text.Where(a => a.ToLower().Contains(word.ToLower())).Select(x => x.ToLower().Replace(word.ToLower(), word.ToUpper())).ToList();
        }

        static List<string> ReadFrom(string path)
        {
            List<string> result = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    result.Add(sr.ReadLine()!);
                }
            }
            return result;
        }



        private static List<string> SearchIn(string path, string name)
        {
            var list = new List<string>();
            DirectoryInfo dir = new DirectoryInfo(path);
            var directories = dir.GetDirectories();
            var fils = dir.GetFiles();
            foreach (var item in fils)
            {
                if (item.Name.Contains(name))
                {
                    list.Add(item.Name);
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



            //        ////Напишите консольную утилиту для копирования файлов
            //        ////Пример запуска: utility.exe file1.txt file2.txt


            //        const string path = @"..\..\..\Program.cs";
            //        const string word = "list";

            //        static void Main(string[] args) { 
            //            var text = ReadFrom(path);
            //            var filter = Filter(word,text); 
            //           Console.WriteLine(String.Join("\n ", filter));
            //        //    foreach (var item in args)
            //        //    {
            //        //        Console.WriteLine(item);
            //        //    };
            //        //    List<string> list = SearchIn(Path: args[0], name : args[1]);
            //        //    Console.WriteLine(String.Join("\n",  list
            //        //        ));

            //            //string str = ReadFrom(args[0]);
            //            //WriteTo(str, args[1]);
            //        }


            //    static List<string> ReadFrom( string path)
            //    {
            //        List<string> result = new List<string>();
            //        using (StreamReader sr = new StreamReader(path))
            //        {
            //            while (!sr.EndOfStream)
            //            {
            //                result.Add(sr.ReadLine()!);
            //            }
            //        }
            //        return result;
            //    }

            //        static  List<string> Filter(string word,List<string> text)
            //        {
            //            return text.Where(a => a.ToLower().Contains(word.ToLower())).Select(x => x.ToLower().Replace(word.ToLower(),word.ToUpper())).ToList();
            //        }

            //        //private static List<string> SearchIn(string Path, string name)
            //        //{
            //        //    var list = new List<string>();
            //        //    DirectoryInfo dir = new DirectoryInfo(Path);
            //        //    var directories = dir.GetDirectories();
            //        //    var fils = dir.GetFiles();
            //        //    foreach ( var item in fils )
            //        //    {
            //        //        if (item.Name.Contains(name))
            //        //        {
            //        //            list.Add(item.Name);
            //        //        }
            //        //        if (item.Extension.Contains(name))
            //        //        {
            //        //            list.Add((string)item.Name);
            //        //        }
            //        //    }
            //        //    foreach( var item in directories)
            //        //    {
            //        //        list.AddRange(SearchIn(item.FullName, name));
            //        //    }

            //        //return list;
            //        //}

            //        //private static void WriteTo(string str, string path)
            //        //{

            //        //    using (FileStream fs = new FileStream(path, FileMode.CreateNew))
            //        //    {
            //        //        using (StreamWriter sw = new StreamWriter(fs))
            //        //        {
            //        //            sw.Write(str);
            //        //        }
            //        //    }

            //        //}

            //        //private static string ReadFrom(string path)
            //        //{
            //        //    StreamReader sr = new StreamReader(path);
            //        //    return sr.ReadToEnd();
            //        //}
  
