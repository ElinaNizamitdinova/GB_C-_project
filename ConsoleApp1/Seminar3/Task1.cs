using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_tasks.Seminar3
{
    public class Task1

    {     
        public void MethodList()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("List:");
            list.ForEach(Console.WriteLine);
            ReversList(list);
            Console.WriteLine("NEW List:");
            list.ForEach(Console.WriteLine);


        }
        public void ReversList(List<int> list) 
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < list.Count; i++)
                stack.Push(list[i]);
            list.Clear();
            for (int i = 0;0 < stack.Count;i++)
                list.Add(stack.Pop());
        }



    }
}
