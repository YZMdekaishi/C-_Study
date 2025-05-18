using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //这个例子说明可以用接口取代委托
            IProductFactory pizzaFactory = new PizzaFactory();
            IProductFactory toycarFactory = new ToyCarFactory();
            WrapFactory warpFactory = new WrapFactory();


            Box box1 = warpFactory.WrapProduct(pizzaFactory);
            Box box2 = warpFactory.WrapProduct(toycarFactory);

            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);

        }
    }

    interface IProductFactory
    {
        Product Make();
    }

    class PizzaFactory:IProductFactory
    {
        public Product Make()
        {
            Product product = new Product();
            product.Name = "Pizza";
            return product;
        }
    }

    class ToyCarFactory:IProductFactory
    {
        public Product Make()
        {
            Product product = new Product();
            product.Name = "Toy Car";
            return product;
        }
    }

    class Product
    {
        public string Name { get; set; }

    }

    class Box
    {

        public Product Product { get; set; }
    }

    class WrapFactory
    {
        public Box WrapProduct(IProductFactory productFactory)
        {
            Box box = new Box();
            Product product = productFactory.Make();
            box.Product = product;
            return box;
        }
    }
}
