using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        public int GetSum(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine($"数组的和为{sum}");
            return sum;
        }

        public void GetAve(int[] a)
        {
            Console.WriteLine($"数组的平均值为{GetSum(a) / a.Length}");
        }

        public void GetMax(int[] a)
        {
            int maxn = a[0];
            for(int i = 1;i < a.Length; i++)
            {
                maxn = (maxn >= a[i]) ? maxn : a[i];
            }
            Console.WriteLine($"数组的最大值为{maxn}");
        }

        public void GetMin(int[] a)
        {
            int minn = a[0];
            for(int i = 1;i < a.Length; i++)
            {
                minn = (minn <= a[i]) ? minn : a[i];
            }
            Console.WriteLine($"数组的最小值为{minn}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("请输入整数数组的长度：");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
            Console.WriteLine("请依次输入整数数组的元素：");
            for(int i = 0; i < length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Program p = new Program();
            p.GetMax(array);
            p.GetMin(array);
            p.GetAve(array);
            p.GetSum(array);

            Console.ReadKey();
        }
    }
}
