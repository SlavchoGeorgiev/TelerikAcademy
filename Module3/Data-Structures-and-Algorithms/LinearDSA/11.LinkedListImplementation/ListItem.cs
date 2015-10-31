namespace _11.LinkedListImplementation
{
    using System;

    public class ListItem<T> : IEquatable<ListItem<T>>
    {
        public ListItem(T value)
            : this(null, value)
        {
        }

        public ListItem(ListItem<T> next, T value)
        {
            this.Next = next;
            this.Value = value;
        }

        public T Value { get; set; }

        public ListItem<T> Next { get; set; }

        public bool Equals(ListItem<T> other)
        {
            return this.Value.Equals(other.Value);
        }
    }
}
