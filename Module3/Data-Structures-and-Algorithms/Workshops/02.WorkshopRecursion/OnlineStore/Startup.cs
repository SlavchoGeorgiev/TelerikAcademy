namespace OnlineStore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Wintellect.PowerCollections;

    public class Product
    {
        private string toString = null;

        public string Name { get; set; }

        public string Producer { get; set; }

        public Decimal Price { get; set; }

        public override string ToString()
        {
            if (this.toString == null)
            {
                toString = string.Format("{{{0};{1};{2}}}", this.Name, this.Producer, this.Price.ToString("F2"));
            }

            return this.toString;
        }
    }

    public class Startup
    {
        public const string NotFoundMessage = "No products found";
        public static StringBuilder sb = new StringBuilder();

        public static MultiDictionary<string, Product> productsByName = new MultiDictionary<string, Product>(true);
        public static MultiDictionary<string, Product> productsByProducer = new MultiDictionary<string, Product>(true);
        public static MultiDictionary<string, Product> productsByNameAndProducer = new MultiDictionary<string, Product>(true);
        public static MultiDictionary<decimal, Product> productsByPrice = new MultiDictionary<decimal, Product>(true);

        public static void Main()
        {
            var numberOfLines = int.Parse(Console.ReadLine());

            for (int lineNumber = 0; lineNumber < numberOfLines; lineNumber++)
            {
                var currentLine = Console.ReadLine();
                var indexOfFirstSpace = currentLine.IndexOf(' ');
                var currentComand = currentLine.Substring(0, indexOfFirstSpace);
                var currentParameters = currentLine.Substring(indexOfFirstSpace + 1).Split(';');

                if (currentComand == "AddProduct")
                {
                    var productForAdd = new Product()
                    {
                        Name = currentParameters[0],
                        Price = decimal.Parse(currentParameters[1]),
                        Producer = currentParameters[2]
                    };

                    productsByName.Add(productForAdd.Name, productForAdd);
                    productsByProducer.Add(productForAdd.Producer, productForAdd);
                    productsByNameAndProducer.Add(productForAdd.Name + productForAdd.Producer, productForAdd);
                    productsByPrice.Add(productForAdd.Price, productForAdd);

                    sb.AppendLine("Product added");
                    //Console.WriteLine("Product added");
                }
                else if (currentComand == "DeleteProducts")
                {
                    if (currentParameters.Length == 1)
                    {
                        DeleteByProducer(currentParameters[0]);
                    }
                    else
                    {
                        DeleteByNameAndProducer(currentParameters[0], currentParameters[1]);
                    }
                }
                else if (currentComand == "FindProductsByName")
                {
                    var result = productsByName[currentParameters[0]];
                    PrintProducts(result);
                }
                else if (currentComand == "FindProductsByPriceRange")
                {
                    decimal minPrice = decimal.Parse(currentParameters[0]);
                    decimal maxPrice = decimal.Parse(currentParameters[1]);

                    var keys = productsByPrice.Keys.Where(k => minPrice <= k && k <= maxPrice);
                    List<Product> result = new List<Product>();

                    foreach (var key in keys)
                    {
                        foreach (var product in productsByPrice[key])
                        {
                            result.Add(product);
                        }
                    }

                    PrintProducts(result);

                    //PrintProducts(productsByPrice
                    //    .Where(p => minPrice <= p.Key && p.Key <= maxPrice)
                    //    .SelectMany(p => p.Value));
                }
                else if (currentComand == "FindProductsByProducer")
                {
                    var result = productsByProducer[currentParameters[0]];
                    PrintProducts(result);
                }
            }
            
            Console.WriteLine(sb.ToString());
        }

        private static void DeleteByNameAndProducer(string productName, string producerName)
        {
            var deletedProducts = productsByNameAndProducer[productName + producerName];
            
            foreach (var deletedProduct in deletedProducts)
            {
                productsByName[deletedProduct.Name].Remove(deletedProduct);
                productsByProducer[deletedProduct.Producer].Remove(deletedProduct);
                productsByPrice[deletedProduct.Price].Remove(deletedProduct);
            }
            
            if (deletedProducts.Count > 0)
            {
                sb.AppendLine(string.Format("{0} products deleted", deletedProducts.Count));
                //Console.WriteLine("{0} products deleted", deletedProducts.Count);

                productsByNameAndProducer.Remove(productName + producerName);
            }
            else
            {
                sb.AppendLine(NotFoundMessage);
                //Console.WriteLine(NotFoundMessage);
            }
        }

        private static void DeleteByProducer(string producerName)
        {
            var deletedProducts = productsByProducer[producerName];

            foreach (var deletedProduct in deletedProducts)
            {
                productsByName[deletedProduct.Name].Remove(deletedProduct);
                productsByNameAndProducer[deletedProduct.Name + deletedProduct.Producer].Remove(deletedProduct);
                productsByPrice[deletedProduct.Price].Remove(deletedProduct);
            }

            if (deletedProducts.Count > 0)
            {
                sb.AppendLine(string.Format("{0} products deleted", deletedProducts.Count));
                //Console.WriteLine("{0} products deleted", deletedProducts.Count);
                productsByProducer.Remove(producerName);
            }
            else
            {
                sb.AppendLine(NotFoundMessage);
                //Console.WriteLine(NotFoundMessage);
            }
        }

        public static void PrintProducts(IEnumerable<Product> productsForPrint)
        {
            productsForPrint = productsForPrint.OrderBy(p => p.ToString());

            foreach (var product in productsForPrint)
            {
                sb.AppendLine(product.ToString());
                //Console.WriteLine(product.ToString());
            }
            
            if (productsForPrint.Count() == 0)
            {
                sb.AppendLine(NotFoundMessage);
                //Console.WriteLine(NotFoundMessage);
            }
        }
    }
}
