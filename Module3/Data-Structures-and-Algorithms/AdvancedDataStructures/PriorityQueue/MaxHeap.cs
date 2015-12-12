namespace PriorityQueue
{
    using System;
    using System.Collections.Generic;

    public class MaxHeap<T> 
        where T : IComparable<T>
    {
        private List<T> array = new List<T>();

        public void Add(T element)
        {
            array.Add(element);
            int index = array.Count - 1;
            while (index > 0 && array[index].CompareTo(array[index / 2]) == 1)
            {
                T tmp = array[index];
                array[index] = array[index / 2];
                array[index / 2] = tmp;
                index = index / 2;
            }
        }

        public T RemoveMax()
        {
            T result = array[0];
            array[0] = array[array.Count - 1];
            array.RemoveAt(array.Count - 1);

            int index = 0;
            while (index < array.Count)
            {
                int max = index;
                if (2*index + 1 < array.Count && array[2*index + 1].CompareTo(array[max]) == 1)
                {
                    max = 2*index + 1;
                }

                if (2*index + 2 < array.Count && array[2*index + 2].CompareTo(array[max]) == 1)
                {
                    max = 2*index + 2;
                }

                if (max == index)
                {
                    break;
                }
                else
                {
                    T tmp = array[index];
                    array[index] = array[max];
                    array[max] = tmp;
                    index = max;
                }
            }

            return result;
        }

        public T Peek()
        {
            return array[0];
        }

        public int Count
        {
            get
            {
                return array.Count;
            }
        }
    }
}
