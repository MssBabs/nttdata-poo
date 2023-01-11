using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Loops
{
    public class PrintProduct
    {
        //public en caso de querer acceder desde los tests
        public static List<Product> products = new List<Product>();

        public static void CreateListProduct()
        {
            var potatoes = new Product
            {
                Id = 1,
                Name = "Patatas",
                Price = 24.56f //La f formatea a float
            };
            products.Add(potatoes);

            var oil = new Product
            {
                Id = 2,
                Name = "Aceite",
                Price = 35.27f
            };
            products.Add(oil);

            var game = new Product
            {
                Id = 3,
                Name = "Juego",
                Price = 39.99f
            };
            products.Add(game);
        }

        public static List<Product> GetProductsGreaterThan30WithFor() 
        {
            var productsGreaterThan30 = new List<Product>();

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Price > 30.00f)
                {
                    productsGreaterThan30.Add(products[i]);
                }
            }

            return productsGreaterThan30;
        }

        public static List<Product> GetProductsGreaterThan30WithForEach() 
        {
            var productsGreaterThan30 = new List<Product>();

            foreach (var product in products)
            {
                if(product.Price > 30.00f) 
                {
                    productsGreaterThan30.Add(product);
                }
            }

            return productsGreaterThan30;
        }

        public static List<Product> GetProductsGreaterThan30WithWhile() 
        {
            var productsGreaterThan30 = new List<Product>();

            var i = 0;
            while (i < products.Count)
            {
                if (products[i].Price > 30.00f)
                {
                    productsGreaterThan30.Add(products[i]);
                }

                i++;
            }

            return productsGreaterThan30;
        }

        public static List<Product> GetProductsGreaterThan30WithLinq() 
        {
            IEnumerable<Product> productsGreaterThan30 =    from product in products
                                                            where product.Price > 30.00f
                                                            select product;

            return productsGreaterThan30.ToList();
        }
    }
}
