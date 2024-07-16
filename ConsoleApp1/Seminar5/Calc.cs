using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_tasks.Seminar5
{
    public class Calc
    {

        static void Calculator_GotResult(object sender, EventArgs e)
        {
            Console.WriteLine(((Calculator)sender).Result);
        }
        static void Calculator_GotResultTwo(object sender, EventArgs e)
        {
            Console.WriteLine($" result = {((Calculator)sender).Result}");
        }
        public void Calculator() {
        bool flag = true;
            while (flag)
            {
                Console.WriteLine("Введте Числа для совершения арифметической операциии.\nЕсли будет проводиться операция деления или вычетания, пожалуйста, укажите большее число первым ");
                int r = Convert.ToInt32(Console.ReadLine());
                int n = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Введите действие которое необхдимо совершить, +,-,*,/");
                char z = Convert.ToChar(Console.ReadLine());
                Calculator calculator = new Calculator();
                calculator.Result = r;
                calculator.GotResult += Calculator_GotResult;
                calculator.GotResult += Calculator_GotResultTwo;
                switch (z)
                {
                    case '+':
                        calculator.Sum(n);
                        break;
                    case '-':
                        calculator.Substruct(n);
                        break;
                    case '*':
                        calculator.Multiply(n);
                        break;
                    case '/':
                        calculator.Divide(n);
                        break;
                    case ' ':
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Неверный знак");
                        break;
                }
            }
}
    }
}
