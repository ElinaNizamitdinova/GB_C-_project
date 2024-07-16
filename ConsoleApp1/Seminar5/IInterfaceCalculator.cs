using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_tasks.Seminar5
{
//    Модифицируйте код калькулятора следующим образом реализовав представленный ниже интерфейс:
//interface ICalc
//    {
//        event EventHandler<EventArgs> GotResult;
//        void Add(int i);
//        void Sub(int i);
//        void Div(int i);
//        void Mul(int i);
//        void CancelLast();
//    }

//    Арифметические методы должны выполняться как обычно а метод CancelLast должен отменять последнее действие.
//    При этом метод может отменить последовательно все действия вплоть до самого последнего.
//    Спросите как студенты планируют реализовать отмену действия и если будут трудности с ответами то подскажите им про стек
    internal interface IInterfaceCalculator
    {

        
        event EventHandler<EventArgs> GotResult;
        void Sum(int firstValue);
        void Substruct(int firstValue);
        void Multiply(int firstValue);
        void Divide(int firstValue);
        void CancelLast();


    }
}
