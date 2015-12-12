namespace Articles
{
    using System;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class Startup
    {
        public static void Main()
        {
            OrderedMultiDictionary<decimal, Article> articles = new OrderedMultiDictionary<decimal, Article>(true);
            
            var numberOfArticles = 100000;
            Console.Write("Adding {0} articles", numberOfArticles);
            for (int i = 0; i < numberOfArticles; i++)
            {
                var currentPrice = (decimal)(i * Math.Abs(Math.Sin(i * 7)));
                var vendorName = string.Format("Vendor {0}", i);

                var article = new Article(vendorName, currentPrice, Math.Abs((732156886486466 ^ i * i) + i * i));

                articles.Add(currentPrice, article);

                if (i % 1000 == 0)
                {
                    Console.Write('.');
                }
            }

            Console.WriteLine();

            var minPrice = 100;
            var maxPrice = 105;

            Console.WriteLine(
                "Products in price range [{0}, {1}] are : {2}{3}", 
                minPrice, 
                maxPrice, 
                Environment.NewLine,
                string.Join(
                    Environment.NewLine, 
                    articles
                    .Range(minPrice, true, maxPrice, true)
                    .Select(p => p.Value.ToString())
                    ));
        }
    }
}
