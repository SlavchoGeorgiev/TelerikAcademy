namespace CollectionOfProducts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Adding products");

            var products = new OrderedMultiDictionary<decimal, string>(true);

            for (int i = 0; i < 500000; i++)
            {
                var currentPrice = (i * Math.Abs(Math.Sin(i)));
                products.Add((decimal)currentPrice, "Product " + i);

                if (i % 5000 == 0)
                {
                    Console.Write(".");
                }
            }
            
            Console.WriteLine();

            decimal minPrice = 100000M;
            decimal maxPrice = 110000M;

            Console.WriteLine("Top 20 product in price range [{0}, {1}]", minPrice, maxPrice);

            var result = products.Range(minPrice, true, maxPrice, true).ToList().Take(20);

            foreach (var product in result)
            {
                Console.WriteLine("Name: {0}, Price: {1}", product.Value, product.Key);
            }
        }
    }
}
