using System;

namespace OrderManagementSystem
{
    [Serializable]
    public class Goods
    {
        public string GoodsName { get; set; }
        public double GoodsPrice { get; set; }

        public Goods() {}
        
        public Goods(string goodsName, double goodsPrice)
        {
            GoodsName = goodsName;
            GoodsPrice = goodsPrice;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return $"goods name: {GoodsName}  goods price: {GoodsPrice}";
        }
    }
}