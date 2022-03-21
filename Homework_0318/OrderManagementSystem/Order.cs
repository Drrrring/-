using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagementSystem
{
    public class Order:IComparable, IComparer<Order>, IEnumerable
    {
        private static int num = 0;
        public int Id { get; }
        public Client Client{ get; set; }
        public double Price { get; } = 0;
        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();

        public Order(Client client, params OrderDetail[] details)
        {
            Id = ++num;
            Client = client ?? throw new ArgumentNullException(nameof(client));
            foreach (var detail in details)
            {
                OrderDetails.Add(detail);
                this.Price += detail.Count * detail.Goods.GoodsPrice * detail.discount;
            }
            
        }

        public bool HasGoods(string goodsName)
        {
            return OrderDetails.Any(orderDetail => orderDetail.Goods.GoodsName.Contains(goodsName));
        }

        public override bool Equals(object? obj)
        {
            Order temp = obj as Order;
            if (temp == null)
                return false;
            return temp.Id == this.Id;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        public override string ToString()
        {
            string info = $"Order {Id}  Price: {Price}  Client: {Client.Name}  \n";
            foreach (var orderDetail in OrderDetails)
            {
                info += $"\t{orderDetail.ToString()}\n";
            }

            return info;
        }

        public IEnumerator GetEnumerator()
        {
            return OrderDetails.GetEnumerator();
        }


        public int CompareTo(object? obj)
        {
            Order temp = obj as Order;
            if(temp == null)
                throw new ArgumentException();
            return this.Id.CompareTo(temp.Id);
        }

        public int Compare(Order? x, Order? y)
        {
            return x.Id - y.Id;
        }
    }
}