namespace _02.IEnumerableExt
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions        
    {
        public static T Sum<T>(this IEnumerable<T> colect)
            where T : IConvertible, IComparable
        {
            dynamic result = default(T);
            foreach (var item in colect)
            {
                result += item;
            }

            return (T)result;
        }

        public static T Product<T>(this IEnumerable<T> colect)
            where T : IConvertible, IComparable
        {
            dynamic result = 1;
            foreach (var item in colect)
            {
                result *= item;
            }

            return (T)result;
        }

        public static T Min<T>(this IEnumerable<T> colect)
            where T : IConvertible, IComparable
        {
            T result = colect.First();
            foreach (var item in colect)
            {
                if (item.CompareTo(result) < 0)
                {
                    result = item;
                }
            }
            return result;
        }

        public static T Max<T>(this IEnumerable<T> colect)
            where T : IConvertible, IComparable
        {
            T result = colect.First();
            foreach (var item in colect)
            {
                if (item.CompareTo(result) > 0)
                {
                    result = item;
                }
            }
            return result;
        }

        public static T Average<T>(this IEnumerable<T> colect)
            where T : IConvertible, IComparable
        {
            return colect.Sum() / (dynamic)colect.Count();
        }
    }
}
