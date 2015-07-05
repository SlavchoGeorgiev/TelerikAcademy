namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class Player
    {
        private string name;
        private int score;

        public Player(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Score
        {
            get { return this.score; }
            set { this.score = value; }
        }

        public static void PrintColection(List<Player> playersColection)
        {
            Console.WriteLine("\nTop players:");

            if (playersColection.Count > 0)
            {
                for (int i = 0; i < playersColection.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} scores", i + 1, playersColection[i].Name, playersColection[i].Score);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There aren't players in list!\n");
            }
        }
    }
}
