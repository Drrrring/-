using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagementSystem
{
    public class OrderService
    {
        public static List<Order> orders { get; } = new List<Order>();

        public static void AddOrder(Order order)
        {
            if (orders.Contains(order))
                throw new Exception("Order has already existed.");
            orders.Add(order);
        }

        //逻辑
        public static void ModifyOrder(int id, Client client)
        {
            Order order = FindOrder(id);
            if (order == null)
                throw new Exception("Cannot find this order");
            order.Client = client;
        }

        //modify n-th orderDetail info
        public static void ModifyOrder(int id, int n, Goods goods, int count, double discount)
        {
            Order order = FindOrder(id);
            if (order == null)
                throw new Exception("Cannot find this order");
            order.OrderDetails[n].Goods = goods;
            order.OrderDetails[n].Count = count;
            order.OrderDetails[n].discount = discount;
        }

        public static void DeleteOrder(int id)
        {
            for (int i = 0; i < orders.Count;)
            {
                if (orders[i].Id == id)
                    orders.Remove(orders[i]);
                else ++i;
            }
        }

        public static Order FindOrder(int id)
        {
            return orders.Find(o => o.Id == id);
        }

        public static List<Order> FindOrder(Func<Order, bool> condition)
        {
            return orders.Where(condition)
                .OrderBy(order => order.Price)
                .ToList();
        }

        public static List<Order> FindOrderByClient(string clientName)
        {
            return FindOrder(order => order.Client.Name.Contains(clientName));
        }

        public static List<Order> FindOrderByGoods(string goodsName)
        {
            return FindOrder(order => order.HasGoods(goodsName)).ToList();
        }

        public static List<Order> FindOrderByPrice(double price)
        {
            return FindOrder(order => Math.Abs(order.Price - price) < 0.00001).ToList();
        }

        public static void Sort()
        {
            orders.Sort();
        }

        public static void Sort(IComparer<Order> comparer)
        {
            orders.Sort(comparer);
        }
    }
}