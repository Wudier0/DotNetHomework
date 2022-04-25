using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    public class OrderDetails
    {
        public Goods Goods { get; set; }
        public int Amount { get; set; }

        public float GoodsTotalPrice
        {
            get => Goods.Price * Amount;
        }

        public OrderDetails(Goods goods,int amount)
        {
            Goods = goods;
            Amount = amount;
        }

        public override bool Equals(object obj)
        {
            var details = obj as OrderDetails;
            return details != null && Goods == details.Goods;
        }

        public override int GetHashCode()
        {
            return Goods.GetHashCode();
        }

        public override string ToString()
        {
            return $"goods:{Goods}, amount:{Amount}, goodsTotalPrice:{GoodsTotalPrice}";
        }
    }
}
