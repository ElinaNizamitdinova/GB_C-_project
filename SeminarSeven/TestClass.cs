using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarSeven
{

    //Дан класс(ниже), создать методы создающий этот класс вызывая один из его конструкторов(по одному конструктору на метод).
    // Задача не очень сложна и служит больше для разогрева перед следующей задачей.
    [AttributeUsage(AttributeTargets.Method)]
    public class CustomNameAttridute : Attribute
    {
        public string Name { get; set; };
    }






        public class TestClass
        {
            public int I { get; set; }
            public string? S { get; set; }
            public decimal D { get; set; }
            public char[]? C { get; set; }

            public TestClass()
            { }
            private TestClass(int i)
            {
                this.I = i;
            }
            public TestClass(int i, string s, decimal d, char[] c) : this(i)
            {
                this.S = s;
                this.D = d;
                this.C = c;
            }

            public static object StringToObject(string s)
            {
                string[] arr = s.Split("|");
                string[] arr1 = arr[0].Split(":");

            //var assembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(a => a.FullName == arr1[0]);
            //var type1 = assembly?.GetTypes().FirstOrDefault(t => t.FullName == arr1[1]);
            object some = Activator.CreateInstance( null, arr1[0].Split(",")[0]);
                if (arr.Length > 1 && some != null)
                {
                    var type = some.GetType();
                    for (int i = 1; i < arr.Length; i++)
                    {
                        string[] nameAndValue = arr[i].Split(":");
                        var p = type.GetProperty(nameAndValue[0]);
                        if (p == null)
                        {
                            continue;
                            if (p.PropertyType == typeof(int))
                            {
                                p.SetValue(some, int.Parse(nameAndValue[1]));

                            }
                            else if (p.PropertyType == typeof(decimal))
                            {
                                p.SetValue(some, decimal.Parse(nameAndValue[1]));
                            }
                            else if (p.PropertyType == typeof(char[]))
                            {
                                p.SetValue(some, nameAndValue[1].ToCharArray());
                            }
                            else if ((p.PropertyType == typeof(string)))
                            {
                                p.SetValue(some, (nameAndValue[1]));
                            }
                        }
                    }

                }
                return some;
            }

    
        [CustomNameAttridute]
        public static string ObjectToString(object o)
            {
                Type t = o.GetType();
                StringBuilder res = new StringBuilder();
                res.Append(t.Namespace + ":");
                res.Append(t.AssemblyQualifiedName + ":");
                res.Append(t.Name + '|');
                var prop = t.GetProperties();
                foreach (var item in prop)
                {
                    var temp = item.GetValue(o);
                    res.Append(item.Name + ":");
                    if (item.PropertyType == typeof(char[]))
                    {
                        res.Append(new string(temp as char[]) + "|");
                    }
                    else
                    {
                        res.Append(temp);
                        res.Append("|");
                    }
                }
                
                return res.ToString();
            }
        }
        //class Test
        //{
        //    public static TestClass MakeTest()
        //    {
        //        Type testClass = typeof(TestClass);
        //        return Activator.CreateInstance(testClass) as TestClass;

        //    }
        //    public static TestClass MakeTest(int i)
        //    {
        //        Type testClass = typeof(TestClass);
        //        return Activator.CreateInstance(testClass, new object[] { 1 }) as TestClass;

        //    }
        //    public static TestClass MakeTest(int i, string s, decimal d, char[] c)
        //    {
        //        Type testClass = typeof(TestClass);
        //        return Activator.CreateInstance(testClass, new object[] {i,s,d,c}) as TestClass;

        //    }



        //}
    }

