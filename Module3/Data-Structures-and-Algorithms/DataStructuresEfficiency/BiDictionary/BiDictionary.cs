namespace BiDictionary
{
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class BiDictionary<TKeyX, TKeyY, T>
    {
        private MultiDictionary<TKeyX, T> xDictionary;

        private MultiDictionary<TKeyY, T> yDictionary;

        public BiDictionary()
        {
            this.xDictionary = new MultiDictionary<TKeyX, T>(true);
            this.yDictionary = new MultiDictionary<TKeyY, T>(true);
        }

        public BiDictionary<TKeyX, TKeyY, T> Add(TKeyX keyX, TKeyY keyY, T value)
        {
            this.xDictionary.Add(keyX, value);
            this.yDictionary.Add(keyY, value);

            return this;
        }


        public ICollection<T> Find(TKeyX keyX, TKeyY keyY)
        {
            var xValues = xDictionary[keyX];
            var yValues = yDictionary[keyY];

            return xValues.Intersect(yValues).ToList();
        }

        public ICollection<T> FindByXKey(TKeyX keyX)
        {
            return this.xDictionary[keyX];
        }

        public ICollection<T> FindByYKey(TKeyY keyY)
        {
            return this.yDictionary[keyY];
        }
    }
}
