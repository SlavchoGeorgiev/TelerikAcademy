namespace JediMeditation
{
    using System;
    using System.Collections;
    using System.Text;

    public class Startup
    {
        static void Main()
        {
            var firstLine = Console.ReadLine();
            var jedies = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Queue masters = new Queue();
            Queue knight = new Queue();
            Queue padawans = new Queue();

            for (int i = 0; i < jedies.Length; i++)
            {
                switch (jedies[i][0])
                {
                    case 'm': masters.Enqueue(jedies[i]);
                        break;
                    case 'k': knight.Enqueue(jedies[i]);
                        break;
                    default: padawans.Enqueue(jedies[i]);
                        break;
                }
            }

            var sb = new StringBuilder();

            while (masters.Count > 0)
            {
                sb.Append(masters.Dequeue());
                sb.Append(" ");
            }

            while (knight.Count > 0)
            {
                sb.Append(knight.Dequeue());
                sb.Append(" ");
            }

            while (padawans.Count > 0)
            {
                sb.Append(padawans.Dequeue());
                sb.Append(" ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
