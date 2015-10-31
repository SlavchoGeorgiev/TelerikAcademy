namespace _02.CompareSimpleMaths
{
    using System;
    using System.Collections.Generic;

    public static class Sorter
    {
        public static T[] InsertionSort<T>(T[] inputArray, Comparer<T> comparer = null) where T : IComparable<T>
        {
            var equalityComparer = comparer ?? Comparer<T>.Default;
            for (var counter = 0; counter < inputArray.Length - 1; counter++)
            {
                var index = counter + 1;
                while (index > 0)
                {
                    if (equalityComparer.Compare(inputArray[index - 1], inputArray[index]) > 0)
                    {
                        var temp = inputArray[index - 1];
                        inputArray[index - 1] = inputArray[index];
                        inputArray[index] = temp;
                    }

                    index--;
                }
            }

            return inputArray;
        }

        public static T[] SelectionSort<T>(T[] inputArray)
            where T : IComparable<T>
        {
            int length = inputArray.Length;

            for (int index = 0; index < inputArray.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(inputArray, index, inputArray.Length - 1);
                Swap(ref inputArray[index], ref inputArray[minElementIndex]);
            }

            return inputArray;
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            int minElementIndex = startIndex;

            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }

        public static T[] QuickSort<T>(T[] inputArray, int left, int right) where T : IComparable<T>
        {
            if (left < right)
            {
                int pivotIdx = Partition(inputArray, left, right);
                QuickSort(inputArray, left, pivotIdx - 1);
                QuickSort(inputArray, pivotIdx, right);
            }

            return inputArray;
        }

        private static int Partition<T>(T[] inputArray, int left, int right) where T : IComparable<T>
        {
            int start = left;
            T pivot = inputArray[start];
            left++;
            right--;

            while (true)
            {
                while (left <= right && inputArray[left].CompareTo(pivot) <= 0)
                {
                    left++;
                }

                while (left <= right && inputArray[left].CompareTo(pivot) > 0)
                {
                    right--;
                }

                if (left > right)
                {
                    inputArray[start] = inputArray[left - 1];
                    inputArray[left - 1] = pivot;

                    return left;
                }


                T temp = inputArray[left];
                inputArray[left] = inputArray[right];
                inputArray[right] = temp;

            }
        }
    }
}
