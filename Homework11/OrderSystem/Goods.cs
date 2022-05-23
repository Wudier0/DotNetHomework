using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class Goods
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Goods(string name,double price)
        {
            Name = name;
            Price = price;
        }

        public Goods() { }

        public override bool Equals(object obj)
        {
            var goods = obj as Goods;
            return goods != null && Name == goods.Name;
        }

        

        public override string ToString()
        {
            return $"goodsName:{Name}, price:{Price}";
        }
    }
}
