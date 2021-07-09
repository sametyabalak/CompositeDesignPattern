using System;
using CompositeDesignPattern;

namespace CompositeDesingPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            // add some products
            IProduct computer = new LeafProduct("Dell Computer", 10);
            IProduct tablet = new LeafProduct("İPad", 3);
            IProduct headphone = new LeafProduct("Beats", 25);


            // add some products
            IProduct table = new LeafProduct("Table", 10);
            IProduct chair = new LeafProduct("Chair", 25);
            IProduct towel = new LeafProduct("Towel", 15);


            // create tree with added products
            Composite electronics = new Composite("Electronic Products");
            Composite decoration = new Composite("Decoration Products");
            Composite allProducts = new Composite("All Products");


            electronics.AddNewProduct(computer);
            electronics.AddNewProduct(tablet);
            electronics.AddNewProduct(headphone);

            decoration.AddNewProduct(table);
            decoration.AddNewProduct(chair);
            decoration.AddNewProduct(towel);

            allProducts.AddNewProduct(decoration);
            allProducts.AddNewProduct(electronics);


            //show computer stock count
            computer.DisplayStockCount();
            
            //show electronic category stock count 
            electronics.DisplayStockCount();

            //show decoration category stock count 
            decoration.DisplayStockCount();

            //show all products stock count
            allProducts.DisplayStockCount();
    


        }
    }
}
