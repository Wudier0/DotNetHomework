using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace OrderSystem
{
    public class OrderService
    {
        public List<Order> Orders = new List<Order>();

        public OrderService() { }

        public void AddOrder(Order order)
        {
            if (!order.IsValid())
            {
                throw new ApplicationException("Invalid order!");
            }
            if (Orders.Contains(order))
            {
                throw new ApplicationException($"The order {order.Id} exists!");
            }
            Orders.Add(order);
        }

        public void DeleteOrder(int orderId)
        {
            if(Orders.Any(order => order.Id == orderId) == false)
            {
                throw new ApplicationException($"The order {orderId} does not exist!");
            }
            Orders.Remove(Orders.Find(order => order.Id == orderId));
        }

        public void ChangeOrder(Order order)
        {
            if(order == null || !order.IsValid())
            {
                throw new ApplicationException("Invalid order!");
            }
            Order orderToChange = Orders.Find(o => o.Id == order.Id);
            if(orderToChange == null)
            {
                throw new ApplicationException($"The order {order.Id} does not exist!");
            }
            Orders.Remove(orderToChange);
            Orders.Add(order);
        }

        public Order SearchOrderById(int orderId)
        {
            return Orders.Find(order => order.Id == orderId);
        }

        public List<Order> SearchOrdersByGoodsName(string goodsName)
        {
            var query = Orders
                .Where(orders => orders.Details.Find(details => details.Goods.Name == goodsName).Goods.Name == goodsName)
                .OrderBy(orders => orders.OrderTotalPrice);
            return query.ToList();
        }

        public List<Order> SearchOrdersByCustomerName(string customerName)
        {
            var query = Orders
                .Where(orders => orders.Customer.Name == customerName)
                .OrderBy(orders => orders.OrderTotalPrice);
            return query.ToList();
        }

        public List<Order> SearchOrdersByTotalPrice(double totalPrice)
        {
            var query = Orders
                .Where(orders => orders.OrderTotalPrice == totalPrice)
                .OrderBy(orders => orders.OrderTotalPrice);
            return query.ToList();
        }

        public List<Order> Sort()
        {
            Orders
                .OrderBy(orders => orders.Id);
            return Orders.ToList();
        }

        public void Export(string filename)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, Orders);
            }
        }

        public void Import(string fileName)
        {
            List<Order> orders;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                orders = (List<Order>)xmlSerializer.Deserialize(fs);
            }
            orders.ForEach(AddOrder);
        }
    }
}
