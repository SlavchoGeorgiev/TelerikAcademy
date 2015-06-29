namespace MyClasses
{
    using System;
    using System.Text;

    public class GenericList<T>
        where T : IComparable
    {
        private const int DefaultCapacity = 4;
        private T[] myList;

        public GenericList() : this(DefaultCapacity)
        {
        }

        public GenericList(int capacity)
        {
            this.myList = new T[capacity];
            this.Capacity = capacity;
            this.Count = 0;
        }

        public int Capacity { get; private set; }

        public int Count { get; private set; }

        public void Add(T element)
        {
            this.AutoGrow();
            this.myList[this.Count] = element;
            this.Count++;
            this.AutoGrow();
        }

        public void Remove(int index)
        {
            this.Access(index);
            for (int i = index; i < this.Count; i++)
            {
                if (!(i + 1 == this.Capacity))
                {
                    this.myList[i] = this.myList[i + 1];
                }
            }

            this.Count--;
        }

        public void Insert(T element, int position)
        {
            this.Count++;
            this.AutoGrow();
            for (int i = this.Count - 1; i > position; i--)
            {
                this.myList[i] = this.myList[i - 1];
            }

            this.myList[position] = element;
        }

        public T Access(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }

            return this.myList[index];
        }

        public int Find(T element)
        {
            int index = Array.IndexOf(this.myList, element);
            return index;
        }

        public void Clear()
        {
            this.Count = 0;
        }

        public T Max()
        {
            T max = this.myList[0];
            for (int i = 0; i < this.Count; i++)
            {
                if (max.CompareTo(this.myList[i]) < 0)
                {
                    max = this.myList[i];
                }
            }

            return max;
        }

        public T Min()
        {
            T min = this.myList[0];

            for (int i = 0; i < this.Count; i++)
            {
                if (min.CompareTo(this.myList[i]) > 0)
                {
                    min = this.myList[i];
                }
            }

            return min;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                sb.Append(this.myList[i].ToString());
                sb.Append(", ");
            }

            return sb.ToString();
        }

        private void AutoGrow()
        {
            if (this.Count >= this.Capacity)
            {
                T[] temp = new T[this.Capacity * 2];
                for (int i = 0; i < this.Capacity; i++)
                {
                    temp[i] = this.myList[i];
                }

                this.myList = temp;
                this.Capacity = this.myList.Length;
            }
        }
    }
}
