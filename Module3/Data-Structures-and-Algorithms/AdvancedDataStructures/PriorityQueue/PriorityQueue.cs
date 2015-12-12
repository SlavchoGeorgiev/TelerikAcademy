namespace PriorityQueue
{
    public class PriorityQueue<T>
    {
        private MaxHeap<PriorityQueueNode<T>> maxHeap = new MaxHeap<PriorityQueueNode<T>>();

        public PriorityQueue<T> Enqueue(int priority, T element)
        {
            maxHeap.Add(new PriorityQueueNode<T>() { Priority = priority, Value = element });

            return this;
        }

        public T Dequeue()
        {
            return maxHeap.RemoveMax().Value;
        }

        public T Peek()
        {
            return maxHeap.Peek().Value;
        }

        public int Count
        {
            get
            {
                return maxHeap.Count;
            }
        }
    }
}
