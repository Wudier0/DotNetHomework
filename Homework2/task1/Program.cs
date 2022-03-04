using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        public void GetPrimeFactor(int number)
        {
            int a = number;

            if (number >= 2)
            {
                Console.WriteLine("这个数的质因数为：");
                for (int i = 2; i <= a; i++)
                {
                    while (a % i == 0)
                    {
                        a = a / i;
                        Console.WriteLine($"{i}");
                    }
                }
            }
            else
            {
                Console.WriteLine("无效输入，应输入大于等于2的整数。");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("请输入大于等于2的整数：");
            int number = Convert.ToInt32(Console.ReadLine());
            Program p = new Program();
            p.GetPrimeFactor(number);

            Console.ReadKey();
        }
    }
}
