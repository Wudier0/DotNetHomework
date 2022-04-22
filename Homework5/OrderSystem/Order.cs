using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem
{
    class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public DateTime CreateTime { get; set; }

        public List<OrderDetails> Details = new List<OrderDetails>();


        public float OrderTotalPrice
        {
            get => Details.Sum(d => d.GoodsTotalPrice);
        }


        public Order(int id,Customer customer)
        {
            Id = id;
            Customer = customer;
            CreateTime = DateTime.Now;
        }

        public bool IsValid()
        {
            return Id > 0 && Details != null && Details.Count > 0;
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null && Id == order.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"orderId:{Id}, customer:{Customer}, details:{Details}, createTime:{CreateTime}, orderTotalPrice:{OrderTotalPrice}";
        }
    }
}
