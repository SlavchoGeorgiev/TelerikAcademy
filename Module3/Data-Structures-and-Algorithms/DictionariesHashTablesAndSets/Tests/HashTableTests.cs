namespace Tests
{
    using HashTable;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HashTableTests
    {
        [TestMethod]
        public void HashTableCountWorksCorectWithAddOfElements()
        {
            var hashTable = new HashTable<int, string>();

            var expectedCount = 50;

            for (int i = 0; i < expectedCount; i++)
            {
                hashTable.Add(i * 2, "Test text " + i);
            }

            Assert.AreEqual(expectedCount, hashTable.Count);
        }

        [TestMethod]
        public void HashTableCountWorksCorectWithAddAndRemoveOfElements()
        {
            var hashTable = new HashTable<int, string>();

            var removedElementsCount = 10;
            var expectedCount = 50 - removedElementsCount;

            for (int i = 0; i < 50; i++)
            {
                hashTable.Add(i, "Test text " + i);
            }

            for (int i = 5; i < removedElementsCount + 5; i++)
            {

                hashTable.Remove(i);
            }

            Assert.AreEqual(expectedCount, hashTable.Count);
        }

        [TestMethod]
        public void AddToHashTableMustWork()
        {
            var hashTable = new HashTable<string, int>();

            var key = "testkey";
            var testValue = 100;

            hashTable.Add(key, testValue);

            Assert.AreEqual(hashTable[key], testValue);
        }

        [TestMethod]
        public void RemoveFromHashTableMustWork()
        {
            var hashTable = new HashTable<string, int>();

            var key = "testkey";
            var testValue = 100;

            hashTable.Add(key, testValue);
            hashTable.Remove(key);

            Assert.AreEqual(hashTable.Count, 0);
        }
    }
}
