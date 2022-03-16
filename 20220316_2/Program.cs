using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220316_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b,c=0;
            char count;
            Console.Write("Num1：");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Num2：");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("operator：");
            count = Convert.ToChar(Console.ReadLine());

            switch(count)
            {
                case '+':
                    c = a + b;
                    break;
                case '-':
                    c = a - b;
                    break;
                case '*':
                    c = a * b;
                    break;
                case '/':
                    c = a / b;
                    break;
                default:
                    c =999999999;
                    break; 
            }
            if(c==999999999) Console.WriteLine("運算子錯誤");
            else Console.WriteLine("Result：" + c);
            Console.ReadLine();
        }
    }
}
