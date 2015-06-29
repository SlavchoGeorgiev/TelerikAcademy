namespace _02.IEnumerableExt
{
    using System;
    class TestExt
    {
        static void Main()
        {

            int[] testArr1 = { 1, 2, 6, 2, 5 };
            foreach (var item in testArr1)
            {
                Console.Write("{0,5}",item);
            }
            Console.WriteLine();
            Console.WriteLine("Sum: {0}", testArr1.Sum());
            Console.WriteLine("Product: {0}", testArr1.Product());
            Console.WriteLine("Min: {0}", testArr1.Min());
            Console.WriteLine("Max: {0}", testArr1.Max());
            Console.WriteLine("Average: {0}", testArr1.Average());

            Console.WriteLine();
            decimal[] testArr2 = { 1.5M, 2.6M, 6.2M, 2M, 5M };
            foreach (var item in testArr2)
            {
                Console.Write("{0,5}", item);
            }
            Console.WriteLine();
            Console.WriteLine("Sum: {0}", testArr2.Sum());
            Console.WriteLine("Product: {0}", testArr2.Product());
            Console.WriteLine("Min: {0}", testArr2.Min());
            Console.WriteLine("Max: {0}", testArr2.Max());
            Console.WriteLine("Average: {0}", testArr2.Average());
        }
    }
}
