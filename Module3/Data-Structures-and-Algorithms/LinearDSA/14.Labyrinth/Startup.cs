namespace _14.Labyrinth
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string[,] labyrinth =
            {
                { "0", "0", "0", "x", "0", "x" },
                { "0", "x", "0", "x", "0", "x" },
                { "0", "*", "x", "0", "x", "0" },
                { "0", "x", "0", "0", "0", "0" },
                { "0", "0", "0", "x", "x", "0" },
                { "0", "0", "0", "x", "0", "x" }
            };

            PrintLabyrinth(labyrinth);

            var labryrinthSolver = new LabyrinthSolver(labyrinth);
            var result = labryrinthSolver.Solve();
            Console.WriteLine(new string('-', 30));
            PrintLabyrinth(result);

            string[,] labyrinthBigTest =
            {
                { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "x", "0", "0", "0" },
                { "0", "x", "x", "0", "x", "x", "x", "x", "0", "0", "x", "0", "x", "0", "x", "0" },
                { "0", "x", "x", "x", "0", "x", "0", "x", "x", "0", "0", "0", "x", "0", "x", "0" },
                { "0", "0", "x", "0", "x", "0", "0", "x", "0", "x", "x", "0", "x", "0", "x", "0" },
                { "x", "0", "x", "0", "0", "0", "0", "x", "x", "0", "x", "0", "0", "x", "0", "0" },
                { "x", "0", "x", "0", "x", "0", "0", "x", "0", "x", "x", "0", "0", "x", "0", "0" },
                { "x", "0", "x", "0", "0", "x", "0", "0", "0", "x", "0", "x", "0", "x", "0", "0" },
                { "0", "0", "0", "0", "0", "x", "0", "0", "0", "0", "x", "0", "0", "0", "0", "0" },
                { "0", "x", "x", "0", "x", "0", "0", "0", "0", "x", "0", "0", "x", "x", "x", "0" },
                { "0", "0", "x", "0", "x", "0", "0", "0", "0", "x", "0", "0", "x", "0", "0", "x" },
                { "0", "0", "x", "0", "x", "0", "0", "0", "0", "0", "x", "x", "x", "*", "0", "0" },
                { "x", "0", "x", "0", "0", "x", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
                { "x", "0", "x", "0", "x", "x", "x", "x", "x", "x", "x", "x", "x", "0", "0", "0" },
                { "x", "0", "x", "x", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" },
            };

            Console.WriteLine(new string('-', 30));
            var biLabryrinthSolver = new LabyrinthSolver(labyrinthBigTest);
            result = biLabryrinthSolver.Solve();
            Console.WriteLine(new string('-', 30));
            PrintLabyrinth(result);
        }

        public static void PrintLabyrinth(string[,] labyrinth)
        {
            for (int row = 0; row < labyrinth.GetLength(0); row++)
            {
                for (int col = 0; col < labyrinth.GetLength(1); col++)
                {
                    Console.Write("{0,-3}", labyrinth[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
