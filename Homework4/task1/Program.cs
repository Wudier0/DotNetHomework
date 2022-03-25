using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Node<T>
    {
        public Node<T> next { get; set; }
        public T data { get; set; }

        public Node(T t)
        {
            next = null;
            data = t;
        }
    }

    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList() { tail = head = null; }

        public Node<T> Head { get => head; }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
                head = tail = n;
            else
            {
                tail.next = n;
                tail = n;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var cur = head;
            while (cur != null)
            {
                yield return cur.data;
                cur = cur.next;
            }
        }

        public void ForEach(Action<T> action)
        {
            foreach (var item in this)
            {
                action(item);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GenericList<double> list = new GenericList<double>();

            Console.WriteLine("请输入链表元素个数：");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("请依次输入元素的值：");
            for (int i = 0; i < n; i++)
            {
                list.Add(Convert.ToDouble(Console.ReadLine()));
            }

            double max = double.MinValue;
            double min = double.MaxValue;
            double sum = 0;

            Console.WriteLine("依次打印链表元素：");
            list.ForEach((x) =>
            {
                Console.WriteLine(x);
                max = Math.Max(max, x);
                min = Math.Min(min, x);
                sum += x;
            });

            Console.WriteLine($"max: {max}");
            Console.WriteLine($"min: {min}");
            Console.WriteLine($"sum: {sum}");

            Console.ReadKey();
        }
    }
}
