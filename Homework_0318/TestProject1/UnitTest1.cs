using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagementSystem;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddOrderTest()
        {
            var order = new Order(new Client("Alice", "1"), new OrderDetail(new Goods("Apple", 12.3), 2));
            OrderService.AddOrder(order);
            var findOrder = OrderService.FindOrder(1);
            Assert.IsNotNull(findOrder);
            Assert.AreEqual(order, findOrder);
            Assert.IsTrue(findOrder.Id == 1);

            // Add duplicated order
            var order2 = new Order(new Client("Alice", "1"), 1, new OrderDetail(new Goods("Apple", 12.3), 2));
            try
            {
                OrderService.AddOrder(order2);
                Assert.Fail("No exception produced");
            }
            catch (Exception e)
            {
                Assert.AreEqual("Order has already existed.", e.Message);
            }
        }

        [TestMethod]
        public void ModifyOrderTest()
        {
            // Modify client info
            var detail1 = new OrderDetail(new Goods("Apple", 12.3), 2);
            var detail2 = new OrderDetail(new Goods("Banana", 2.3), 3);
            var detail3 = new OrderDetail(new Goods("Pear", 12.5), 5);
            var good = new Goods("Grape", 15);

            var order = new Order(new Client("Felix", "2"), 2, detail1, detail2, detail3);
            OrderService.AddOrder(order);
            Client client = new Client("Jenny", "3");
            OrderService.ModifyOrder(2, client);
            Assert.AreEqual(client.Name, order.Client.Name);
            Assert.AreEqual(client.ClientId, order.Client.ClientId);

            //Modify n-th orderDetail info
            OrderService.ModifyOrder(2, 2, good, 3, 0.8);
            var toCheck = OrderService.FindOrder(2);
            Assert.AreEqual(good.GoodsName, toCheck.OrderDetails[2].Goods.GoodsName);
            Assert.AreEqual(good.GoodsPrice, toCheck.OrderDetails[2].Goods.GoodsPrice);
            Assert.AreEqual(3, toCheck.OrderDetails[2].Count);
            Assert.AreEqual(0.8, toCheck.OrderDetails[2].Discount);

            // Order not found
            try
            {
                OrderService.ModifyOrder(100, client);
                Assert.Fail("Order not found");
            }
            catch (Exception e)
            {
                Assert.AreEqual("Cannot find this order", e.Message);
            }

            try
            {
                OrderService.ModifyOrder(100, 2, good, 3, 0.8);
                Assert.Fail("Order not found");
            }
            catch (Exception e)
            {
                Assert.AreEqual("Cannot find this order", e.Message);
            }

            // Detail not found
            try
            {
                OrderService.ModifyOrder(2, 3, good, 3, 0.8);
                Assert.Fail("Order not found");
            }
            catch (Exception e)
            {
                Assert.AreEqual("Detail not found", e.Message);
            }
        }

        [TestMethod]
        public void DeleteOrderTest()
        {
            OrderService.AddOrder(new Order(new Client("Alice", "1"), 3, new OrderDetail(new Goods("Apple", 12.3), 2)));
            Order toCheck = OrderService.FindOrder(3);
            Assert.IsNotNull(toCheck);
            OrderService.DeleteOrder(3);
            toCheck = OrderService.FindOrder(3);
            Assert.IsNull(toCheck);
        }

        [TestMethod]
        public void FindOrderTest()
        {
            var order1 = new Order(new Client("Alice", "9"), 1, new OrderDetail(new Goods("Apple", 21.3), 2));
            var order2 = new Order(new Client("Felix", "9"), 2, new OrderDetail(new Goods("Banana", 22.3), 2));
            var order3 = new Order(new Client("Alice", "9"), 3, new OrderDetail(new Goods("Pear", 23.3), 2));
            var order4 = new Order(new Client("Tom", "9"), 4, new OrderDetail(new Goods("Grape", 24.3), 1),
                new OrderDetail(new Goods("Apple", 21.3), 1));
            OrderService.AddOrder(order1);
            OrderService.AddOrder(order2);
            OrderService.AddOrder(order3);
            OrderService.AddOrder(order4);
            var toCheck = OrderService.FindOrder(1);
            Assert.AreEqual(order1.Client.Name, toCheck.Client.Name);
            Assert.AreEqual(order1.Client.ClientId, toCheck.Client.ClientId);
            Assert.AreEqual(order1.Id, toCheck.Id);
            Assert.AreEqual(order1.Price, toCheck.Price);
            Assert.AreEqual(order1.OrderDetails, toCheck.OrderDetails);

            // Overload version
            List<Order> ordersToCheck1 = OrderService.FindOrder(o => Math.Abs(o.Price - 42.6) < 0.01);
            List<Order> ordersToCheck2 = OrderService.FindOrder(o => o.Client.Name.Equals("Alice"));
            List<Order> ordersToCheck3 = OrderService.FindOrder(o => o.HasGoods("Grape"));

            Assert.IsTrue(ordersToCheck1.Count == 1 && ordersToCheck1[0].Id == 1);
            Assert.IsTrue(ordersToCheck2.Count == 2 && ordersToCheck2[0].Id == 1 && ordersToCheck2[1].Id == 3);
            Assert.IsTrue(ordersToCheck3.Count == 1 && ordersToCheck3[0].Id == 4);
        }

        [TestMethod]
        public void FindOrderByClientTest()
        {
            var order1 = new Order(new Client("Alice", "9"), 1, new OrderDetail(new Goods("Apple", 21.3), 2));
            var order2 = new Order(new Client("Felix", "9"), 2, new OrderDetail(new Goods("Banana", 22.3), 2));
            var order3 = new Order(new Client("Alice", "9"), 3, new OrderDetail(new Goods("Pear", 23.3), 2));
            var order4 = new Order(new Client("Tom", "9"), 4, new OrderDetail(new Goods("Grape", 24.3), 1),
                new OrderDetail(new Goods("Apple", 21.3), 1));
            OrderService.AddOrder(order1);
            OrderService.AddOrder(order2);
            OrderService.AddOrder(order3);
            OrderService.AddOrder(order4);

            List<Order> toCheck = OrderService.FindOrderByClient("Alice");
            Assert.IsTrue(toCheck.Count == 2 && toCheck[0].Id == 1 && toCheck[1].Id == 3);
        }

        [TestMethod]
        public void FindOrderByGoodsTest()
        {
            var order1 = new Order(new Client("Alice", "9"), 1, new OrderDetail(new Goods("Apple", 21.3), 2));
            var order2 = new Order(new Client("Felix", "9"), 2, new OrderDetail(new Goods("Banana", 22.3), 2));
            var order3 = new Order(new Client("Alice", "9"), 3, new OrderDetail(new Goods("Pear", 23.3), 2));
            var order4 = new Order(new Client("Tom", "9"), 4, new OrderDetail(new Goods("Grape", 24.3), 1),
                new OrderDetail(new Goods("Apple", 21.3), 1));
            OrderService.AddOrder(order1);
            OrderService.AddOrder(order2);
            OrderService.AddOrder(order3);
            OrderService.AddOrder(order4);

            List<Order> toCheck = OrderService.FindOrderByGoods("Apple");
            Assert.IsTrue(toCheck.Count == 2 && toCheck[0].Id == 1 && toCheck[1].Id == 4);
        }

        [TestMethod]
        public void FindOrderByPriceTest()
        {
            var order1 = new Order(new Client("Alice", "9"), 1, new OrderDetail(new Goods("Apple", 21.3), 2));
            var order2 = new Order(new Client("Felix", "9"), 2, new OrderDetail(new Goods("Banana", 22.3), 2));
            var order3 = new Order(new Client("Alice", "9"), 3, new OrderDetail(new Goods("Pear", 23.3), 2));
            var order4 = new Order(new Client("Tom", "9"), 4, new OrderDetail(new Goods("Grape", 24.3), 1),
                new OrderDetail(new Goods("Apple", 21.3), 1));
            OrderService.AddOrder(order1);
            OrderService.AddOrder(order2);
            OrderService.AddOrder(order3);
            OrderService.AddOrder(order4);

            List<Order> toCheck = OrderService.FindOrderByPrice(42.6);
            Assert.IsTrue(toCheck.Count == 1 && toCheck[0].Id == 1);
        }

        [TestMethod]
        public void ExportTest()
        {
            var order1 = new Order(new Client("Alice", "1"), 1, new OrderDetail(new Goods("Apple", 21.3), 2));
            var order2 = new Order(new Client("Felix", "2"), 2, new OrderDetail(new Goods("Banana", 22.3), 2));
            var order3 = new Order(new Client("Alice", "1"), 3, new OrderDetail(new Goods("Pear", 23.3), 2));
            var order4 = new Order(new Client("Tom", "3"), 4, new OrderDetail(new Goods("Grape", 24.3), 1),
                new OrderDetail(new Goods("Apple", 21.3), 1));
            OrderService.AddOrder(order1);
            OrderService.AddOrder(order2);
            OrderService.AddOrder(order3);
            OrderService.AddOrder(order4);
            OrderService.Export();
        }

        [TestMethod]
        public void ImportTest()
        {
            // Some info in Order cannot be serialized.
            
            // var order1 = new Order(new Client("Alice", "1"), 1, new OrderDetail(new Goods("Apple", 21.3), 2));
            // var order2 = new Order(new Client("Felix", "2"), 2, new OrderDetail(new Goods("Banana", 22.3), 2));
            // var order3 = new Order(new Client("Alice", "1"), 3, new OrderDetail(new Goods("Pear", 23.3), 2));
            // var order4 = new Order(new Client("Tom", "3"), 4, new OrderDetail(new Goods("Grape", 24.3), 1),
            //     new OrderDetail(new Goods("Apple", 21.3), 1));
            var orderImport = OrderService.Import();
            Assert.AreEqual(4,orderImport.Count);
        }

        [TestCleanup]
        public void CleanUp()
        {
            OrderService.DeleteAll();
        }
    }
}