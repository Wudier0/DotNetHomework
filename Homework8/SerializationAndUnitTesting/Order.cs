using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem { 

    [Serializable]
    public class Order
    {
        private List<OrderDetails> details;
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public string CustomerName { get => Customer.Name; }
        public DateTime CreateTime { get; set; }
        public List<OrderDetails> Details { get { return details; } }


        public double OrderTotalPrice
        {
            get => Details.Sum(d => d.GoodsTotalPrice);
        }


        public Order(int id,Customer customer)
        {
            Id = id;
            Customer = customer;
            CreateTime = DateTime.Now;
            details = new List<OrderDetails>();
        }

        public Order() {CreateTime = DateTime.Now; details = new List<OrderDetails>(); }

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
            return Id;
        }

        public override string ToString()
        {
            return $"orderId:{Id}, customer:{Customer}, details:{Details}, createTime:{CreateTime}, orderTotalPrice:{OrderTotalPrice}";
        }
    }
}
