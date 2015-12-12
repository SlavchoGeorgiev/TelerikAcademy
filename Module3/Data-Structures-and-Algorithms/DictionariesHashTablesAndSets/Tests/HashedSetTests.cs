namespace Tests
{
    using HashedSet;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HashedSetTests
    {
        [TestMethod]
        public void HashSetCountWorksCorectWithAddOfElements()
        {
            var hashSet = new HashedSet<int>();

            var expectedCount = 50;

            for (int i = 0; i < expectedCount; i++)
            {
                hashSet.Add(i);
            }

            Assert.AreEqual(expectedCount, hashSet.Count());
        }

        [TestMethod]
        public void HashSetCountWorksCorectWithAddAndRemoveOfElements()
        {
            var hashedSet = new HashedSet<int>();

            var removedElementsCount = 10;
            var expectedCount = 50 - removedElementsCount;

            for (int i = 0; i < 50; i++)
            {
                hashedSet.Add(i);
            }

            for (int i = 5; i < removedElementsCount + 5; i++)
            {

                hashedSet.Remove(i);
            }

            Assert.AreEqual(expectedCount, hashedSet.Count());
        }

        [TestMethod]
        public void AddToHashSetMustWork()
        {
            var hashedSet = new HashedSet<int>();

            var key = 5;

            hashedSet.Add(key);

            Assert.AreEqual(hashedSet.Count(), 1);
        }

        [TestMethod]
        public void RemoveFromHashSetMustWork()
        {
            var hashedSet = new HashedSet<int>();

            var key = 10;

            hashedSet.Add(key);
            hashedSet.Remove(key);

            Assert.AreEqual(hashedSet.Count(), 0);
        }
    }
}
