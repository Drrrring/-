using System;

namespace OrderManagementSystem
{
    public class OrderDetail
    {
        public Goods Goods { get; set; }
        public int Count { get; set; }
        public double discount;

        public OrderDetail(Goods goods, int count, double discount = 1)
        {
            this.Goods = goods ?? throw new ArgumentNullException(nameof(goods));
            this.Count = count;
            this.discount = discount;
        }

        public OrderDetail(string name, double price, int count, double discount = 1)
        {
            Goods = new Goods(name, price);
            this.Count = count;
            this.discount = discount;
        }

        public override bool Equals(object? obj)
        {
            OrderDetail temp = obj as OrderDetail;
            if (temp == null)
                return false;
            if (this.Goods.GoodsName == temp.Goods.GoodsName)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return this.Goods.GoodsName.GetHashCode();
        }

        public override string ToString()
        {
            return Goods.ToString() + $"  count: {Count}  discount: {discount}";
        }
    }
}