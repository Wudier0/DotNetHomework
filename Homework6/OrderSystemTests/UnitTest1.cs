using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using OrderSystem;
using System.Xml.Serialization;
using System.IO;

namespace OrderSystemTests
{
    [TestClass]
    public class UnitTest1
    {
        OrderService orderService = new OrderService();

        static Customer customer1 = new Customer(1, "张三");
        static Customer customer2 = new Customer(2, "李四");
        static Customer customer3 = new Customer(3, "王五");
        static Customer customer4 = new Customer(4, "马六");
        static Customer customer5 = new Customer(5, "冯七");
        static Customer customer6 = new Customer(6, "陈八");
        static Customer customer7 = new Customer(7, "刘九");
        static Customer customer8 = new Customer(8, "林十");

        static Goods goods1 = new Goods("milk", (float)2.5);
        static Goods goods2 = new Goods("water", (float)2.0);
        static Goods goods3 = new Goods("bread", (float)5.5);
        static Goods goods4 = new Goods("egg", (float)1.5);
        static Goods goods5 = new Goods("paper", (float)3.5);
        static Goods goods6 = new Goods("pen", (float)6.5);
        static Goods goods7 = new Goods("apple", (float)9.8);
        static Goods goods8 = new Goods("meat", (float)15.3);

        OrderDetails orderDetails1 = new OrderDetails(goods1, 50);
        OrderDetails orderDetails2 = new OrderDetails(goods2, 100);
        OrderDetails orderDetails3 = new OrderDetails(goods3, 30);
        OrderDetails orderDetails4 = new OrderDetails(goods4, 300);
        OrderDetails orderDetails5 = new OrderDetails(goods5, 500);
        OrderDetails orderDetails6 = new OrderDetails(goods6, 80);
        OrderDetails orderDetails7 = new OrderDetails(goods7, 40);
        OrderDetails orderDetails8 = new OrderDetails(goods8, 20);

        Order order1 = new Order(1, customer1);
        Order order2 = new Order(2, customer2);
        Order order3 = new Order(3, customer3);
        Order order4 = new Order(4, customer4);
        Order order5 = new Order(5, customer5);
        Order order6 = new Order(6, customer6);
        Order order7 = new Order(7, customer7);
        Order order8 = new Order(8, customer8);


        [TestInitialize]
        public void Create()
        {
            order1.Details.Add(orderDetails1);
            order1.Details.Add(orderDetails2);
            order1.Details.Add(orderDetails3);


            order2.Details.Add(orderDetails6);
            order2.Details.Add(orderDetails1);
            order2.Details.Add(orderDetails3);
            order2.Details.Add(orderDetails5);

            order3.Details.Add(orderDetails4);

            order4.Details.Add(orderDetails1);
            order4.Details.Add(orderDetails8);

            order5.Details.Add(orderDetails1);
            order5.Details.Add(orderDetails2);
            order5.Details.Add(orderDetails3);
            order5.Details.Add(orderDetails5);
            order5.Details.Add(orderDetails6);
            order5.Details.Add(orderDetails8);

            order6.Details.Add(orderDetails1);
            order6.Details.Add(orderDetails5);
            order6.Details.Add(orderDetails3);

            order7.Details.Add(orderDetails4);
            order7.Details.Add(orderDetails8);

            order8.Details.Add(orderDetails4);
            order8.Details.Add(orderDetails7);

            orderService.Orders.Add(order1);
            orderService.Orders.Add(order2);
            orderService.Orders.Add(order3);
            orderService.Orders.Add(order4);
        }
            
        

        [TestMethod]
        public void AddOrderTest()
        {
            orderService.AddOrder(order5);
            Assert.AreEqual(5, orderService.Orders.Count);
            CollectionAssert.Contains(orderService.Orders, order5);
        }

        [TestMethod]
        public void DleteOrderTest()
        {
            orderService.DeleteOrder(1);
            Assert.AreEqual(3, orderService.Orders.Count);
            orderService.DeleteOrder(10);
            Assert.AreEqual(3, orderService.Orders.Count);
        }

        [TestMethod]
        public void ChangeOrderTest()
        {
            Order newOrder1 = new Order(1, customer1);
            newOrder1.Details.Add(orderDetails1);
            newOrder1.Details.Add(orderDetails2);
            newOrder1.Details.Add(orderDetails3);
            newOrder1.Details.Add(orderDetails4);
            orderService.ChangeOrder(newOrder1);
            Assert.AreEqual(4, orderService.Orders.Count);
            Order o = orderService.SearchOrderById(1);
            Assert.AreEqual(newOrder1, o);
        }

        [TestMethod]
        public void SearchOrderByIdTest()
        {
            Order o = orderService.SearchOrderById(2);
            Assert.IsNotNull(o);
            Assert.AreEqual(order2, o);
            CollectionAssert.AreEqual(order2.Details, o.Details);
        }

        [TestMethod]
        public void SearchOrdersByGoodsNameTest()
        {
            List<Order> orders = new List<Order>();
            orders = orderService.SearchOrdersByGoodsName("milk");
            Assert.IsNotNull(orders);
            Assert.AreEqual(5, orders.Count);
            CollectionAssert.Contains(orders, order1);
            CollectionAssert.Contains(orders, order2);
            CollectionAssert.Contains(orders, order4);
            CollectionAssert.Contains(orders, order5);
            CollectionAssert.Contains(orders, order6);
        }

        [TestMethod]
        public void SearchOrdersByCustomerNameTest()
        {
            List<Order> orders = new List<Order>();
            orders = orderService.SearchOrdersByCustomerName("张三");
            Assert.IsNotNull(orders);
            Assert.AreEqual(1, orders.Count);
            CollectionAssert.Contains(orders, order1);
        }

        [TestMethod]
        public void SearchOrdersByTotalPrice()
        {
            List<Order> orders = new List<Order>();
            orders = orderService.SearchOrdersByTotalPrice((float)490.0);
            Assert.IsNotNull(orders);
            Assert.AreEqual(1, orders.Count);
            CollectionAssert.Contains(orders, order1);
        }

        [TestMethod]
        public void ExportTest()
        {
            orderService.Export();
            Assert.IsTrue(File.Exists("Orders.xml"));
            File.Delete("Orders.xml");
        }

        [TestMethod]
        public void ImportTest()
        {
            string path = "order5.xml";
            orderService.Import(path);
            Assert.AreEqual(5, orderService.Orders.Count);
            CollectionAssert.Contains(orderService.Orders, order5);
        }
    }
}
