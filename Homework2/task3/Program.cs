using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        public void AiShi(int n, int[] a)
        {
            int k = 2;
            while (k * k <= n)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] % k == 0 && a[i] != k && a[i] != 0)
                    {
                        a[i] = 0;
                    }
                }
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > k)
                    {
                        k = a[i];
                        break;
                    }
                }
            }
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {
                    Console.WriteLine($"{a[i]}");
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[99];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = i + 2;

            Console.WriteLine("素数为：");
            Program p = new Program();
            p.AiShi(arr[98], arr);

            Console.ReadKey();
        }
    }
}
