using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    interface Polygon
    {
        double GetArea();
        bool IsLegal();
    }

    class Rectangle : Polygon
    {
        public double length;
        public double width;

        public Rectangle(double len,double wid)
        {
            length = len;
            width = wid;
        }

        public double GetArea()
        {
            if (IsLegal())
                return width * length;
            else
                throw new Exception("长方形不合法");

        }

        public bool IsLegal()
        {
            return width > 0 && length > width;
        }
    }

    class Square : Polygon
    {
        public double sideLength;

        public Square(double sLen) { sideLength = sLen; }

        public double GetArea()
        {
            if(IsLegal())
                return sideLength * sideLength;
            else
                throw new Exception("正方形不合法");
        }

        public bool IsLegal()
        {
            return sideLength > 0;
        }
    }

    class Triangle : Polygon
    {
        public double sideLength1;
        public double sideLength2;
        public double sideLength3;

        public Triangle(double sLen1,double sLen2,double sLen3)
        {
            sideLength1 = sLen1;
            sideLength2 = sLen2;
            sideLength3 = sLen3;
        }

        public double GetArea()
        {
            if (IsLegal())
            {
                double p = (sideLength1 + sideLength2 + sideLength3) / 2;
                double area = System.Math.Sqrt(p * (p - sideLength1) * (p - sideLength2) * (p - sideLength3));
                return area;
            }
            else
                throw new Exception("三角形不合法");
        }

        public bool IsLegal()
        {
            return sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1;
        }
    }

    class Factory
    {
        public Polygon CreatePolygon()
        {
            Random polygonType = new Random();

            switch (polygonType.Next(0,3))
            {
                case 0:
                    Random len = new Random();
                    Random wid = new Random();
                    double l = len.Next(0, 100);
                    double w = wid.Next(0, 100);
                    Console.WriteLine($"创建长方形，长为{l}，宽为{w}");
                    return new Rectangle(l , w);
                case 1:
                    Random sLen = new Random();
                    double s = sLen.Next(0, 100);
                    Console.WriteLine($"创建正方形，边长为{s}");
                    return new Square(s);
                case 2:
                    Random sLen1 = new Random();
                    Random sLen2 = new Random();
                    Random sLen3 = new Random();
                    double s1 = sLen1.Next(0, 100);
                    double s2 = sLen2.Next(0, 100);
                    double s3 = sLen3.Next(0, 100);
                    Console.WriteLine($"创建三角形，三边长分别为{s1}，{s2}，{s3}");
                    return new Triangle(sLen1.Next(0,100),sLen2.Next(0,100),sLen3.Next(0,100));
                default:
                    throw new Exception("非法形状选择");
            }
        }
    }

    class Demo
    {
        static void main(string[] args)
        {
            Factory p = new Factory();

            Console.WriteLine("请输入要生成的形状个数：");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine($"正在生成第{i}个形状......");
                p.CreatePolygon().GetArea();
            }

            Console.ReadKey();
        }
    }
}
