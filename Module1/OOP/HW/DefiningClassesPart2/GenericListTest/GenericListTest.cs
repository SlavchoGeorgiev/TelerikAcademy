using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClasses;

namespace GenericListTest
{
    class GenericListTest
    {
        static void Main()
        {
            GenericList<Decimal> testGenList = new GenericList<decimal>();
            testGenList.Add(125.53M);
            testGenList.Add(123);
            testGenList.Add(100);
            testGenList.Add(1000);
            testGenList.Add(10000);
            Console.WriteLine(testGenList.ToString());
            Console.WriteLine(testGenList.Find(100));
            Console.WriteLine(testGenList.Access(1));
            Console.WriteLine(testGenList.Capacity);
            testGenList.Insert(0, 0);
            testGenList.Insert(5, 3);
            testGenList.Remove(testGenList.Count - 1);
            Console.WriteLine(testGenList.ToString());
            testGenList.Insert(16.16M, testGenList.Count - 1);
            testGenList.Insert(17.17M, testGenList.Count - 1);
            testGenList.Insert(18.18M, testGenList.Count - 1);
            testGenList.Insert(19.19M, testGenList.Count - 1);
            Console.WriteLine(testGenList.ToString());
            Console.WriteLine(testGenList.Max());
            testGenList.Remove(testGenList.Find(testGenList.Max()));
            Console.WriteLine(testGenList.ToString());
            Console.WriteLine(testGenList.Max());
            Console.WriteLine(testGenList.Min());
            testGenList.Remove(0);
            Console.WriteLine(testGenList.Min());
            testGenList.Clear();
            Console.WriteLine(testGenList.ToString());
        }
    }
}
