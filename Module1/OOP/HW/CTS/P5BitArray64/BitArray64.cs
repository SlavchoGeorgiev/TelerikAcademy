namespace P5BitArray64
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64 : IEnumerable<int>
    {
        public BitArray64()
            : this(default(ulong))
        { 
        }

        public BitArray64(ulong initilValue)
        {
            this.ArrayAsUlong = initilValue;
        }

        public ulong ArrayAsUlong { get; protected set; }

        public byte this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return (byte)((this.ArrayAsUlong & ((ulong)1 << index)) >> index);
                }
            }

            set
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException();
                }

                if (value != 0 && value != 1)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.ArrayAsUlong = this.ArrayAsUlong & ~((ulong)1 << index) | ((ulong)value << index);
            }
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return ulong.Equals(first.ArrayAsUlong, second.ArrayAsUlong);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !ulong.Equals(first.ArrayAsUlong, second.ArrayAsUlong);
        }

        public override bool Equals(object param)
        {
            return ulong.Equals(this.ArrayAsUlong, (param as BitArray64).ArrayAsUlong);
        }

        public override int GetHashCode()
        {
            return this.ArrayAsUlong.GetHashCode();
        }

        public override string ToString()
        {
            var toString = new StringBuilder();
            for (sbyte i = 63; i >= 0; i--)
            {
                toString.Append(this[i]);
            }

            return toString.ToString();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
