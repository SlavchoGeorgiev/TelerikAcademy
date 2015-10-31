namespace _11.LinkedListImplementation
{
    using System.Collections;
    using System.Collections.Generic;

    public class LinkedList<T> : IEnumerable<ListItem<T>>
    {
        public LinkedList()
            : this(null)
        {
        }

        public LinkedList(ListItem<T> firstListItem)
        {
            this.Add(firstListItem);
        }

        public ListItem<T> First { get; private set; }

        public ListItem<T> Last { get; private set; }

        public LinkedList<T> Add(ListItem<T> item)
        {
            if (this.First == null)
            {
                this.First = item;
                this.Last = item;
            }

            this.Last.Next = item;
            this.Last = item;

            return this;
        }

        public LinkedList<T> Remove(ListItem<T> item)
        {
            foreach (var currentItem in this)
            {
                if (currentItem.Next.Equals(item))
                {
                    if (currentItem.Next == this.Last)
                    {
                        this.Last = currentItem;
                    }

                    currentItem.Next = currentItem.Next.Next;
                    return this;
                }
            }

            return this;
        }

        public IEnumerator<ListItem<T>> GetEnumerator()
        {
            var currentElement = this.First;
            while (currentElement != null)
            {
                yield return currentElement;
                currentElement = currentElement.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
