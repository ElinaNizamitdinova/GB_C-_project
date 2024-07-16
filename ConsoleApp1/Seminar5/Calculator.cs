using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_tasks.Seminar5
{
    public class Calculator : IInterfaceCalculator
    {
        
        public event EventHandler<EventArgs> GotResult;
        public int Result = 0;
        Stack<int> GetLast = new Stack<int>();
        public void Divide(int firstValue)
        {
            GetLast.Push(Result);
            Result/=firstValue;
            RaiseEvent();
            
        }

        public void Multiply(int firstValue)
        {
            GetLast.Push(Result);
            Result *= firstValue;
            RaiseEvent();
        }

        public void Substruct(int firstValue)
        {
            GetLast.Push(Result);
            Result -= firstValue;
            RaiseEvent();

        }

        public void Sum(int firstValue)
        {
            GetLast.Push(Result);
            Result += firstValue;
            RaiseEvent();
        }
        private void RaiseEvent()
        {
            GotResult?.Invoke(this, EventArgs.Empty);
        }

        public void CancelLast()
        {
            if (GetLast.Count > 0)
            {
                Result = GetLast.Pop();
                RaiseEvent();
            }

        }
    }
}
