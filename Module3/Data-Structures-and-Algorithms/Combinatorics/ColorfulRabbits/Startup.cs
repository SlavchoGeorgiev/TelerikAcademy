namespace ColorfulRabbits
{
    using System;
    using System.Collections.Generic;
    using System.IO.Pipes;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Dictionary<int, int> groupedAnswers = new Dictionary<int, int>();
            int result = 0;


            int numberOfLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLines; i++)
            {
                int answer = int.Parse(Console.ReadLine());

                if (!groupedAnswers.ContainsKey(answer + 1))
                {
                    groupedAnswers.Add(answer + 1, 1);
                    result = result + answer + 1;
                }
                else
                {
                    groupedAnswers[answer + 1]++;

                    if (groupedAnswers[answer + 1] > answer + 1)
                    {
                        result = result + answer + 1;
                        groupedAnswers[answer + 1] = 1;
                    }
                }
            }
            
            Console.WriteLine(result);
        }
    }
}
