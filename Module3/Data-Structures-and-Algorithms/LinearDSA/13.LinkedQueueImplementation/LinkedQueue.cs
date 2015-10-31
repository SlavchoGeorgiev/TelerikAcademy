namespace _13.LinkedQueueImplementation
{
    using System.Collections.Generic;

    public class LinkedQueue<T>
    {
        private LinkedList<T> linkedList;

        public LinkedQueue()
        {
            this.linkedList = new LinkedList<T>();
        }

        public int Count
        {
            get { return this.linkedList.Count; }
        }

        public LinkedQueue<T> Enqueue(T item)
        {
            this.linkedList.AddLast(item);

            return this;
        }

        public T Dequeue()
        {
            var item = this.linkedList.First;
            this.linkedList.RemoveFirst();

            return item.Value;
        }

        public T Peek()
        {
            return this.linkedList.First.Value;
        }
    }
}