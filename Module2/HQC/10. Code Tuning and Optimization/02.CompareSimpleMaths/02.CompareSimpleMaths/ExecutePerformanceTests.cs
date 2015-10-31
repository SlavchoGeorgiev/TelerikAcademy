namespace _02.CompareSimpleMaths
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ExecutePerformanceTests
    {
        static void Main()
        {

            //Task 2. Compare simple Maths
            var testValue = 2;
            var testCount = 5;
            var iterationsCountPerTest = 5000000;

            //Task 2. Compare simple Maths

            Console.WriteLine(MathTester.TestIntAdding(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestLongAdding(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestFloatAdding(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestDoubleAdding(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestDecimalAdding(testValue, testCount, iterationsCountPerTest));

            Console.WriteLine();
            Console.WriteLine(MathTester.TestIntSubtract(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestLongSubtract(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestFloatSubtract(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestDoubleSubtract(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestDecimalSubtract(testValue, testCount, iterationsCountPerTest));

            Console.WriteLine();
            Console.WriteLine(MathTester.TestIntIncrement(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestLongIncrement(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestFloatIncrement(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestDoubleIncrement(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestDecimalIncrement(testValue, testCount, iterationsCountPerTest));

            Console.WriteLine();
            Console.WriteLine(MathTester.TestIntMultiply(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestLongMultiply(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestFloatMultiply(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestDoubleMultiply(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestDecimalMultiply(testValue, testCount, iterationsCountPerTest));

            Console.WriteLine();
            Console.WriteLine(MathTester.TestIntDivide(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestLongDivide(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestFloatDivide(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestDoubleDivide(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestDecimalDivide(testValue, testCount, iterationsCountPerTest));

            //Task 3. Compare advanced Maths

            Console.WriteLine();
            Console.WriteLine(MathTester.TestFloatSqrt(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestDoubleSqrt(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestDecimalSqrt(testValue, testCount, iterationsCountPerTest));

            Console.WriteLine();
            Console.WriteLine(MathTester.TestFloatLog(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestDoubleLog(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestDecimalLog(testValue, testCount, iterationsCountPerTest));

            Console.WriteLine();
            Console.WriteLine(MathTester.TestFloatSin(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestDoubleSin(testValue, testCount, iterationsCountPerTest));
            Console.WriteLine(MathTester.TestDecimalSin(testValue, testCount, iterationsCountPerTest));

            //Task 4.* Compare sort algorithms
            var arrayLength = 100;
            iterationsCountPerTest = iterationsCountPerTest / 10000;
            int[] arrayOfIntSorted = new int[arrayLength];
            int[] arrayOfIntRversedSorted = new int[arrayLength];
            int[] arrayOfIntRandomOrder = new int[arrayLength];
            double[] arrayOfDoubleSorted = new double[arrayLength];
            double[] arrayOfDoubleRversedSorted = new double[arrayLength];
            double[] arrayOfDoubleRandomOrder = new double[arrayLength];
            string[] arrayOfStringsRandomOrder = { "Dd", "cd", "dc", "a", "ab", "Dd", "cd", "dc", "a", "ab", "Dd", "cd", "dc", "a", "ab", "Dd", "cd", "dc", "a", "ab", "Dd", "cd", "dc", "a", "ab", "Dd", "cd", "dc", "a", "ab", "Dd", "cd", "dc", "a", "ab", "Dd", "cd", "dc", "a", "ab", "Dd", "cd", "dc", "a", "ab", "Dd", "cd", "dc", "a", "ab", "Dd", "cd", "dc", "a", "ab", "Dd", "cd", "dc", "a", "ab", "Dd", "cd", "dc", "a", "ab", "Dd", "cd", "dc", "a", "ab", "Dd", "cd", "dc", "a", "ab", "Dd", "cd", "dc", "a", "ab", "Dd", "cd", "dc", "a", "ab", "Dd", "cd", "dc", "a", "ab", "Dd", "cd", "dc", "a", "ab", "Dd", "cd", "dc", "a", "ab" };
            string[] arrayOfStringsSorted = arrayOfStringsRandomOrder.OrderBy(x => x).ToArray();
            string[] arrayOfStringsRversedSorted = arrayOfStringsRandomOrder.OrderByDescending(x => x).ToArray();
            Random randomGenerator = new Random();

            for (int i = 0; i < arrayLength; i++)
            {
                arrayOfIntSorted[i] = i;
                arrayOfIntRversedSorted[i] = arrayLength - i;
                arrayOfIntRandomOrder[i] = randomGenerator.Next();

                arrayOfDoubleSorted[i] = i / 2;
                arrayOfDoubleRversedSorted[i] = arrayLength - i / 2;
                arrayOfDoubleRandomOrder[i] = randomGenerator.NextDouble();

            }

            Console.WriteLine();
            Console.WriteLine("Input array is sorted");
            Console.WriteLine(SortTester.TestInsertionSort(arrayOfIntSorted, testCount, iterationsCountPerTest));
            Console.WriteLine(SortTester.TestInsertionSort(arrayOfDoubleSorted, testCount, iterationsCountPerTest));
            Console.WriteLine(SortTester.TestInsertionSort(arrayOfStringsSorted, testCount, iterationsCountPerTest));
            Console.WriteLine();
            Console.WriteLine(SortTester.TestSelectionSort(arrayOfIntSorted, testCount, iterationsCountPerTest));
            Console.WriteLine(SortTester.TestSelectionSort(arrayOfDoubleSorted, testCount, iterationsCountPerTest));
            Console.WriteLine(SortTester.TestSelectionSort(arrayOfStringsSorted, testCount, iterationsCountPerTest));
            Console.WriteLine();
            Console.WriteLine(SortTester.TestQuickSort(arrayOfIntSorted, testCount, iterationsCountPerTest));
            Console.WriteLine(SortTester.TestQuickSort(arrayOfDoubleSorted, testCount, iterationsCountPerTest));
            Console.WriteLine(SortTester.TestQuickSort(arrayOfStringsSorted, testCount, iterationsCountPerTest));
            Console.WriteLine();
            Console.WriteLine("Input array is sorted in reversed order");
            Console.WriteLine(SortTester.TestInsertionSort(arrayOfIntRversedSorted, testCount, iterationsCountPerTest));
            Console.WriteLine(SortTester.TestInsertionSort(arrayOfDoubleRversedSorted, testCount, iterationsCountPerTest));
            Console.WriteLine(SortTester.TestInsertionSort(arrayOfStringsRversedSorted, testCount, iterationsCountPerTest));
            Console.WriteLine();
            Console.WriteLine(SortTester.TestSelectionSort(arrayOfIntRversedSorted, testCount, iterationsCountPerTest));
            Console.WriteLine(SortTester.TestSelectionSort(arrayOfDoubleRversedSorted, testCount, iterationsCountPerTest));
            Console.WriteLine(SortTester.TestSelectionSort(arrayOfStringsRversedSorted, testCount, iterationsCountPerTest));
            Console.WriteLine();
            Console.WriteLine(SortTester.TestQuickSort(arrayOfIntRversedSorted, testCount, iterationsCountPerTest));
            Console.WriteLine(SortTester.TestQuickSort(arrayOfDoubleRversedSorted, testCount, iterationsCountPerTest));
            Console.WriteLine(SortTester.TestQuickSort(arrayOfStringsRversedSorted, testCount, iterationsCountPerTest));
            Console.WriteLine();
            Console.WriteLine("Input array with random values");
            Console.WriteLine(SortTester.TestInsertionSort(arrayOfIntRandomOrder, testCount, iterationsCountPerTest));
            Console.WriteLine(SortTester.TestInsertionSort(arrayOfDoubleRandomOrder, testCount, iterationsCountPerTest));
            Console.WriteLine(SortTester.TestInsertionSort(arrayOfStringsRandomOrder, testCount, iterationsCountPerTest));
            Console.WriteLine();
            Console.WriteLine(SortTester.TestSelectionSort(arrayOfIntRandomOrder, testCount, iterationsCountPerTest));
            Console.WriteLine(SortTester.TestSelectionSort(arrayOfDoubleRandomOrder, testCount, iterationsCountPerTest));
            Console.WriteLine(SortTester.TestSelectionSort(arrayOfStringsRandomOrder, testCount, iterationsCountPerTest));
            Console.WriteLine();
            Console.WriteLine(SortTester.TestQuickSort(arrayOfIntRandomOrder, testCount, iterationsCountPerTest));
            Console.WriteLine(SortTester.TestQuickSort(arrayOfDoubleRandomOrder, testCount, iterationsCountPerTest));
            Console.WriteLine(SortTester.TestQuickSort(arrayOfStringsRandomOrder, testCount, iterationsCountPerTest));
        }
    }
}
