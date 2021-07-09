using System;
using CompositeDesingPattern;
namespace CompositeDesignPattern
{
    public class LeafProduct : IProduct
    {
        public int StockCount { get; set; }
        public string Name { get; set; }
        public LeafProduct(string name, int stockCount)
        {
            this.StockCount = stockCount;
            this.Name = name;
        }

        public void DisplayStockCount()
        {
            Console.WriteLine(Name + " : " + StockCount);
        }
    }
}