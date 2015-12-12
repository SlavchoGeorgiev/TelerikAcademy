namespace KnapsackProblem
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static Product[] products;
        public static long mask;
        public static Dictionary<int, List<Product>> weightSumProducts;
        public static Dictionary<int, int> weightSumCostSum;
        public static int maxCostSum = 0;

        public static void Main()
        {
            Console.Write("Knapsack of capacity: ");
            int capacity = int.Parse(Console.ReadLine());
            Console.Write("Products number: ");
            int n = int.Parse(Console.ReadLine());

            products = new Product[n];
            mask = 1 << n;
            weightSumProducts = new Dictionary<int, List<Product>>();
            weightSumCostSum = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Product {i + 1} name: ");
                var name = Console.ReadLine();
                Console.Write($"Product {i + 1} weight: ");
                var weight = int.Parse(Console.ReadLine());
                Console.Write($"Product {i + 1} cost: ");
                var cost = int.Parse(Console.ReadLine());

                products[i] = new Product() { Name = name, Weight = weight, Cost = cost };
            }

            for (int i = 0; i < mask; i++)
            {
                int weightSum = 0;
                int costSum = 0;

                for (int j = 0; j < n; j++)
                {
                    if ((i & (1 << j)) != 0)
                    {
                        weightSum += products[j].Weight;
                        costSum += products[j].Cost;
                    }
                }

                if (!weightSumProducts.ContainsKey(weightSum) && weightSum <= capacity)
                {
                    weightSumProducts.Add(weightSum, new List<Product>());
                    weightSumCostSum.Add(weightSum, costSum);
                }

                if (weightSumCostSum.ContainsKey(weightSum) && weightSumCostSum[weightSum] <= costSum && weightSum <= capacity)
                {
                    weightSumCostSum[weightSum] = costSum;
                    weightSumProducts[weightSum].Clear();

                    for (int j = 0; j < n; j++)
                    {
                        if ((i & (1 << j)) != 0)
                        {
                            weightSumProducts[weightSum].Add(products[j]);
                        }
                    }
                }
            }


            int maxCost = 0;
            int maxWeight = 0;
            foreach (var pair in weightSumCostSum)
            {
                if (pair.Value >= maxCost)
                {
                    maxCost = pair.Value;
                    maxWeight = pair.Key;
                }
            }

            var productsInBag = weightSumProducts[maxWeight];
            Console.WriteLine(string.Join(" + ", productsInBag));
            Console.WriteLine("weight = {0}", maxWeight);
            Console.WriteLine("cost = {0}", maxCost);
            /*
            Knapsack of capacity: 10
            Products number: 6
            Product 1 name: b
            Product 1 weight: 3
            Product 1 cost: 2
            Product 2 name: v
            Product 2 weight: 8
            Product 2 cost: 12
            Product 3 name: c
            Product 3 weight: 4
            Product 3 cost: 5
            Product 4 name: n
            Product 4 weight: 1
            Product 4 cost: 4
            Product 5 name: h
            Product 5 weight: 2
            Product 5 cost: 3
            Product 6 name: w
            Product 6 weight: 8
            Product 6 cost: 13
            n + w
            weight = 9
            cost = 17
            */
        }
    }
}
