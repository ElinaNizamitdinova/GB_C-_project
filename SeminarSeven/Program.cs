using static System.Net.Mime.MediaTypeNames;

namespace SeminarSeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] t = new char[] { '1', '2' };
            var n3 = MakeTest(5, "xg", 10, t);
            var some = TestClass.ObjectToString(n3);
            var some1 = TestClass.StringToObject(some);
            Console.WriteLine(some);
            Console.WriteLine(some1);

        }

        static TestClass MakeTest()
        {
            Type testClass = typeof(TestClass);
            return Activator.CreateInstance(testClass) as TestClass;

        }
        static TestClass MakeTest(int i)
        {
            Type testClass = typeof(TestClass);
            return Activator.CreateInstance(testClass, new object[] { 1 }) as TestClass;

        }
         static TestClass MakeTest(int i, string s, decimal d, char[] c)
        {
            Type testClass = typeof(TestClass);
            return Activator.CreateInstance(testClass, new object[] { i, s, d, c }) as TestClass;

        }
    }
}
