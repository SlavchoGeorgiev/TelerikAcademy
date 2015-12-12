namespace HashTable
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            var hashTable = new HashTable<int,string>();

            hashTable.Add(1, "Test")
                .Add(2, "Test 2")
                .Add(3, "Test 3")
                .Add(0, "Test 4")
                .Add(16, "Test 5")
                .Add(19, "Test 37")
                .Add(19, "Test 200")
                .Remove(3);

            for (int i = 20; i < 50; i++)
            {
                hashTable.Add(i, "String " + i);
            }

            Console.WriteLine(string.Join(" ", hashTable.Keys));
            Console.WriteLine(hashTable[2]);
            foreach (var pair in hashTable)
            {
                Console.WriteLine(pair);
            }
        }
    }
}
