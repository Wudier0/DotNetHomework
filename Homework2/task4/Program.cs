using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        public bool IsToplitzMatrix(double[,] a)
        {
            double k = a[0, 0];
            int i = 0, j = 0;
            while (i <= a.GetUpperBound(0) && j <= a.GetUpperBound(1))
            {
                if (a[i, j] != k)
                {
                    return false;
                }
                i++;
                j++;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int m, n;
            Console.WriteLine("请输入矩阵的行数：");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入矩阵的列数：");
            n = Convert.ToInt32(Console.ReadLine());

            double[,] mat = new double[m,n];

            for(int i = 0; i < m; i++)
            {
                Console.WriteLine($"请依次输入第{i + 1}行的数：");
                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            Program p = new Program();
            p.IsToplitzMatrix(mat);

            Console.ReadKey();
        }
    }
}
