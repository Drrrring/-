﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderManagementSystem_WebAPI.Models
{
    public class OrderService
    {
        //public static List<Order> orders { get; } = new List<Order>();
        public static List<Order> GetAllOrders()
        {
            using(var context = new OrderContext())
            {
                return context.Orders.ToList<Order>();
            }
        }

        public static void AddOrder(Order order)
        {
            //database
            using (var context = new OrderContext())
            {
                context.Database.EnsureCreated();
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }

        //逻辑
        public static void ModifyOrder(Order newOrder)
        {
            DeleteOrder(newOrder.Id);
            using (OrderContext context = new OrderContext())
            {
                context.Orders.Add(newOrder);
                context.SaveChanges();
            }
        }


        public static void DeleteOrder(int id)
        {
            //db
            using (var context = new OrderContext())
            {
                Order toDelete = FindOrder(id);
                if (toDelete != null)
                {
                    context.OrdersDetails.RemoveRange(toDelete.OrderDetails);
                    context.Orders.Remove(toDelete);
                    context.SaveChanges(true);
                }
            }
        }

        public static Order FindOrder(int id)
        {
            //return orders.Find(o => o.Id == id);

            //db
            using (var context = new OrderContext())
            {
                return context.Orders.FirstOrDefault(o => o.Id == id);
            }
        }

        public static List<Order> FindOrder(Func<Order, bool> condition)
        {
            using (var context = new OrderContext())
            {
                return context.Orders.Where(condition)
                                .OrderBy(order => order.Price)
                                .ToList();
            }

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



        public static void Export(string filePath = "orders.xml")
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (var context = new OrderContext())
            {
                List<Order> orders = context.Orders.ToList<Order>();
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    xmlSerializer.Serialize(fs, orders);
                }
            }

        }

        public static List<Order> Import(string filePath = "orders.xml")
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                return (List<Order>)xmlSerializer.Deserialize(fs);
            }
        }
    }
}