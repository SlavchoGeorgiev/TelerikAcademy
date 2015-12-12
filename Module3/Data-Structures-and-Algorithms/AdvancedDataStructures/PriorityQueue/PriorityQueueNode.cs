namespace PriorityQueue
{
    using System;

    internal class PriorityQueueNode<T> : IComparable<PriorityQueueNode<T>>
    {
        public int Priority { get; set; }

        public T Value { get; set; }

        public int CompareTo(PriorityQueueNode<T> other)
        {
            return Priority.CompareTo(other.Priority);
        }
    }
}
