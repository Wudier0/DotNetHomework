using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        double a, b, s;
        char c;

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public double Mut(double a, double b)
        {
            return a * b;
        }

        public double Div(double a, double b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine("请按顺序输入要做运算的两个数：");

            p.a = double.Parse(Console.ReadLine());
            p.b = double.Parse(Console.ReadLine());

            Console.WriteLine("请输入运算符：");

            p.c = char.Parse(Console.ReadLine());

            switch (p.c)
            {
                case '+':
                    p.s = p.Add(p.a, p.b);
                    break;

                case '-':
                    p.s = p.Sub(p.a, p.b);
                    break;

                case '*':
                    p.s = p.Mut(p.a, p.b);
                    break;

                case '/':
                    p.s = p.Div(p.a, p.b);
                    break;

                default:
                    Console.WriteLine("无效输入");
                    break;
            }

            Console.WriteLine("运算结果为{0}", p.s);
            Console.ReadLine();
        }
    }
}
