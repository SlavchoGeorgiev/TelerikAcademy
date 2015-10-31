namespace _11.LinkedListImplementation
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var linkedList = new LinkedList<int>(new ListItem<int>(10));
            linkedList.Add(new ListItem<int>(5))
                .Add(new ListItem<int>(4))
                .Add(new ListItem<int>(-5))
                .Add(new ListItem<int>(8))
                .Add(new ListItem<int>(11))
                .Remove(new ListItem<int>(11))
                .Remove(new ListItem<int>(-5))
                .Add(new ListItem<int>(20))
                .Add(new ListItem<int>(25));

            foreach (var listItem in linkedList)
            {
                Console.Write(listItem.Value + " ");
            }
        }
    }
}
