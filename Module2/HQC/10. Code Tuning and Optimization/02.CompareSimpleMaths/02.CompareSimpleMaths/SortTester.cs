namespace _02.CompareSimpleMaths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    class SortTester
    {
        private const string resultFormat = "Test for {0} of {1}. Average time: {2} milliseconds";

        public static string TestInsertionSort<T>(T[] inputArray, int testCount, int iterationsCountPerTest) where T : IComparable<T>
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    T[] sortResult = Sorter.InsertionSort(inputArray);
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "Insertion Sort", inputArray[0].GetType().Name, testResults.Average());
        }

        public static string TestSelectionSort<T>(T[] inputArray, int testCount, int iterationsCountPerTest) where T : IComparable<T>
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    T[] sortResult = Sorter.SelectionSort(inputArray);
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "Selection Sort", inputArray[0].GetType().Name, testResults.Average());
        }

        public static string TestQuickSort<T>(T[] inputArray, int testCount, int iterationsCountPerTest) where T : IComparable<T>
        {
            List<long> testResults = new List<long>();

            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < testCount; i++)
            {
                sw.Start();
                for (int j = 0; j < iterationsCountPerTest; j++)
                {
                    T[] sortResult = Sorter.QuickSort(inputArray, 0, inputArray.Length);
                }

                sw.Stop();
                testResults.Add(sw.ElapsedMilliseconds);
                sw.Reset();
            }

            return string.Format(resultFormat, "Quick Sort", inputArray[0].GetType().Name, testResults.Average());
        }
    }
}
