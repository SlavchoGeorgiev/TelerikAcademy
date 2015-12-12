namespace FindAllPaths
{
    using System;
    using System.Linq;

    public class Startup
    {
        static void Main()
        {
            string[,] matrix = new string[,]
            {
                {"S", "X", " ", " ", " ", " ", " " },
                {" ", "X", " ", "X", "X", "X", " " },
                {" ", "X", " ", " ", " ", "X", " " },
                {" ", "X", " ", "X", "X", "X", " " },
                {" ", "X", " ", " ", " ", " ", "E" },
                {" ", "X", " ", "X", " ", "X", " " },
                {" ", " ", " ", "X", " ", " ", " " },
                {" ", "X", " ", " ", "X", "X", "X" }
            };

            FindAllPaths(matrix, 0, 0, 0);
        }

        public static void FindAllPaths(string[,] matrix, int row, int col, int direction)
        {
            var directions = new int[,] { { -1, 0 }, { 0, 1 }, { 1, 0 }, { 0, -1 } };

            for (int i = 0; i < directions.GetLength(0); i++)
            {
                if (IsValidMove(matrix, row + directions[i, 0], col + directions[i, 1]))
                {
                    if (matrix[row + directions[i, 0], col + directions[i, 1]] == "E")
                    {
                        MarkCurrentPosition(matrix, row, col, i);
                        PrintMatrix(matrix);
                        matrix[row, col] = " ";
                        return;
                    }
                    else
                    {
                        MarkCurrentPosition(matrix, row, col, i);
                        FindAllPaths(matrix, row + directions[i, 0], col + directions[i, 1], i);
                    }
                }
            }

            matrix[row, col] = " ";
        }

        private static void MarkCurrentPosition(string[,] matrix, int row, int col, int direction)
        {
            if (matrix[row, col] != "S")
            {
                switch (direction)
                {
                    case 0:
                        matrix[row, col] = "^";
                        break;
                    case 1:
                        matrix[row, col] = ">";
                        break;
                    case 2:
                        matrix[row, col] = "v";
                        break;
                    case 3:
                        matrix[row, col] = "<";
                        break;
                }
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((new string[] { "^", ">", "v", "<" }).Any(d => d == matrix[i, j]))
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if (matrix[i,j] == "S" || matrix[i, j] == "E")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    Console.Write(matrix[i, j]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("|");
                }
                Console.WriteLine();
                Console.WriteLine(new string('-', matrix.GetLength(1) * 2));
            }
            Console.WriteLine(new string('#', matrix.GetLength(1) * 2));
        }

        public static bool IsValidMove(string[,] matrix, int row, int col)
        {
            if (row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1))
            {
                if (matrix[row, col] != "X" && (new string[] { "^", ">", "v", "<" }).All(d => d != matrix[row, col]) && matrix[row, col] != "S")
                {
                    return true;
                }
            }

            return false;
        }
    }
}
