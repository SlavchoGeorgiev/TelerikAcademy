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

        public static Dictionary<string, List<Product>> productsByName = new Dictionary<string, List<Product>>();
        public static Dictionary<string, List<Product>> productsByProducer = new Dictionary<string, List<Product>>();
        public static Dictionary<string, List<Product>> productsByNameAndProducer = new Dictionary<string, List<Product>>();
        public static Dictionary<decimal, List<Product>> productsByPrice = new Dictionary<decimal, List<Product>>();

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
                    
                    if (!productsByName.ContainsKey(productForAdd.Name))
                    {
                        productsByName.Add(productForAdd.Name, new List<Product>());
                    }
                    productsByName[productForAdd.Name].Add(productForAdd);
                    
                    if (!productsByProducer.ContainsKey(productForAdd.Producer))
                    {
                        productsByProducer.Add(productForAdd.Producer, new List<Product>());
                    }
                    productsByProducer[productForAdd.Producer].Add(productForAdd);
                    
                    var nameProducerKey = productForAdd.Name + productForAdd.Producer;
                    if (!productsByNameAndProducer.ContainsKey(nameProducerKey))
                    {
                        productsByNameAndProducer.Add(nameProducerKey, new List<Product>());
                    }
                    productsByNameAndProducer[nameProducerKey].Add(productForAdd);
                    
                    if (!productsByPrice.ContainsKey(productForAdd.Price))
                    {
                        productsByPrice.Add(productForAdd.Price, new List<Product>());
                    }
                    productsByPrice[productForAdd.Price].Add(productForAdd);

                    sb.AppendLine("Product added");
                }
                else if (currentComand == "DeleteProducts")
                {
                    if (currentParameters.Length == 1)
                    {
                        var producerName = currentParameters[0];
                        if (productsByProducer.ContainsKey(producerName))
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
                                productsByProducer.Remove(producerName);
                            }
                            else
                            {
                                sb.AppendLine(NotFoundMessage);
                            }
                        }
                        else
                        {
                            sb.AppendLine(NotFoundMessage);
                        }
                    }
                    else
                    {
                        var productName = currentParameters[0];
                        var producerName = currentParameters[1];

                        var nameProducerKey = productName + producerName;
                        if (productsByNameAndProducer.ContainsKey(nameProducerKey))
                        {
                            var deletedProducts = productsByNameAndProducer[nameProducerKey];

                            foreach (var deletedProduct in deletedProducts)
                            {
                                productsByName[deletedProduct.Name].Remove(deletedProduct);
                                productsByProducer[deletedProduct.Producer].Remove(deletedProduct);
                                productsByPrice[deletedProduct.Price].Remove(deletedProduct);
                            }

                            if (deletedProducts.Count > 0)
                            {
                                sb.AppendLine(string.Format("{0} products deleted", deletedProducts.Count));

                                productsByNameAndProducer.Remove(productName + producerName);
                            }
                            else
                            {
                                sb.AppendLine(NotFoundMessage);
                            }
                        }
                        else
                        {
                            sb.AppendLine(NotFoundMessage);
                        }
                    }
                }
                else if (currentComand == "FindProductsByName")
                {
                    if (productsByName.ContainsKey(currentParameters[0]))
                    {
                        var result = productsByName[currentParameters[0]];
                        if (result.Count() > 0)
                        {
                            PrintProducts(result);
                        }
                        else
                        {
                            sb.AppendLine(NotFoundMessage);
                        }
                    }
                    else
                    {
                        sb.AppendLine(NotFoundMessage);
                    }
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

                    if (result.Count > 0)
                    {
                        PrintProducts(result);
                    }
                    else
                    {
                        sb.AppendLine(NotFoundMessage);
                    }
                }
                else if (currentComand == "FindProductsByProducer")
                {
                    if (productsByProducer.ContainsKey(currentParameters[0]))
                    {
                        var result = productsByProducer[currentParameters[0]];
                        if (result.Count > 0)
                        {
                            PrintProducts(result);
                        }
                        else
                        {
                            sb.AppendLine(NotFoundMessage);
                        }
                    }
                    else
                    {
                        sb.AppendLine(NotFoundMessage);
                    }
                }
            }

            Console.WriteLine(sb.ToString());
        }

        public static void PrintProducts(IEnumerable<Product> productsForPrint)
        {
            productsForPrint = productsForPrint.OrderBy(p => p.ToString());

            foreach (var product in productsForPrint)
            {
                sb.AppendLine(product.ToString());
            }
        }
    }
}
