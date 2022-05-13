using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public Goods Goods { get; set; }
        public string GoodsName { get => Goods.Name; }
        public double GoodsPrice { get => Goods.Price; }
        public int Amount { get; set; }

        public double GoodsTotalPrice
        {
            get => Goods.Price * Amount;
        }

        public OrderDetails(int id, Goods goods,int amount)
        {
            Id = id;
            Goods = goods;
            Amount = amount;
        }

        public OrderDetails() { }

        public override bool Equals(object obj)
        {
            var details = obj as OrderDetails;
            return details != null && Goods == details.Goods;
        }

        

        public override string ToString()
        {
            return $"goods:{Goods}, amount:{Amount}, goodsTotalPrice:{GoodsTotalPrice}";
        }
    }
}
