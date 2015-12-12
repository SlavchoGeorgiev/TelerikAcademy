namespace HashTable
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class HashTable<K, T> : IEnumerable<KeyValuePair<K, T>>
    {
        private LinkedList<KeyValuePair<K, T>>[] table;
        private ICollection<K> keys;

        public HashTable(int size = 16)
        {
            this.table = new LinkedList<KeyValuePair<K, T>>[size];
            this.Count = 0;
            this.Size = size;
            this.keys = new LinkedList<K>();
        }

        public IEnumerable<K> Keys { get { return this.keys; } }

        public int Size { get; private set; }

        public int Count { get; private set; }

        public T this[K key]
        {
            get { return this.Find(key); }
        }

        public HashTable<K, T> Add(K key, T value)
        {
            int index = this.GetIndex(key);

            if (this.table[index] == null)
            {
                this.table[index] = new LinkedList<KeyValuePair<K, T>>();
            }

            if (!this.table[index].Any(p => p.Key.Equals(key)))
            {
                this.table[index].AddLast(new KeyValuePair<K, T>(key, value));
                this.Count++;
                this.keys.Add(key);
            }
            else
            {
                //throw new ArgumentException(string.Format("Hash table already contains this key: {0}", key));
                this.table[index].Remove(this.table[index].FirstOrDefault(p => p.Key.Equals(key)));
                this.table[index].AddLast(new KeyValuePair<K, T>(key, value));
            }

            if ((this.Count / this.Size) > 0.75)
            {
                this.Resize();
            }

            return this;
        }

        public HashTable<K, T> Remove(K key)
        {
            int index = this.GetIndex(key);

            if (this.table[index] != null && this.table[index].Any(p => p.Key.Equals(key)))
            {
                this.table[index]
                    .Remove(this.table[index]
                                .FirstOrDefault(p => p.Key.Equals(key)));
                this.Count--;
                this.keys.Remove(key);
            }

            return this;
        }

        public T Find(K key)
        {
            int index = GetIndex(key);

            if (this.table[index] == null)
            {
                throw new KeyNotFoundException();
            }
            else if (this.table[index].Any(p => p.Key.Equals(key)))
            {
                return this.table[index].FirstOrDefault(p => p.Key.Equals(key)).Value;
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }

        public HashTable<K, T> Clear()
        {
            this.table = new LinkedList<KeyValuePair<K, T>>[this.Size];
            this.Count = 0;
            this.keys = new LinkedList<K>();

            return this;
        }

        private void Resize()
        {
            var oldTable = this.table;
            this.Size = this.Size * 2;

            this.Clear();

            foreach (var list in oldTable)
            {
                if (list != null)
                {
                    foreach (var pair in list)
                    {
                        this.Add(pair.Key, pair.Value);
                    }
                }
            }
        }

        private int GetIndex(K key)
        {
            return key.GetHashCode() % this.Size;
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            foreach (var list in this.table)
            {
                if (list != null)
                {
                    foreach (var pair in list)
                    {
                        yield return new KeyValuePair<K, T>(pair.Key, pair.Value);
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
