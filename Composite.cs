using System;
using System.Collections.Generic;
using CompositeDesingPattern;

namespace CompositeDesignPattern
{
    public class Composite : IProduct
    {
        public string Name { get; set; }
        List<IProduct> products = new List<IProduct>();

        public Composite(string name)
        {
            this.Name = name;
        }

        public void AddNewProduct(IProduct product)
        {
            products.Add(product);
        }

        public void DisplayStockCount()
        {
            Console.WriteLine(Name);
            foreach (var product in products)
            {
                product.DisplayStockCount();
            }
        }
    }
}