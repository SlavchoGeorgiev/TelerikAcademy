namespace HashedSet
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using HashTable;

    public class HashedSet<T> : IEnumerable<T>
    {
        private HashTable<T, bool> set;

        public HashedSet()
        {
            this.set = new HashTable<T, bool>();
        }

        public HashedSet<T> Add(T value)
        {
            this.set.Add(value, true);

            return this;
        }

        public HashedSet<T> Remove(T value)
        {
            this.set.Remove(value);

            return this;
        }

        public bool Find(T value)
        {
            return this.set.Find(value);
        }

        public HashedSet<T> Clear()
        {
            this.set.Clear();

            return this;
        }

        public int Count()
        {
            return set.Count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var pair in set)
            {
                yield return pair.Key;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
