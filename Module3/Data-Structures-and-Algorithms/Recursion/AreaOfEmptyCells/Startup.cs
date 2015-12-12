namespace AreaOfEmptyCells
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static int maxAreaCellsCount = 0;
        public static string[,] maxAreaResult;
        public static int[,] directions = new int[,] { { -1, 0 }, { 0, 1 }, { 1, 0 }, { 0, -1 } };
        public static Stack<Cell> cells = new Stack<Cell>();

        public static void Main()
        {
            string[,] matrix = new string[,]
            {
                {" ", "X", " ", "X", " ", " ", "X" },
                {" ", "X", " ", "X", "X", "X", " " },
                {"X", " ", " ", "X", " ", "X", " " },
                {"X", " ", "X", "X", "X", "X", "X" },
                {" ", " ", " ", "X", " ", "X", " " },
                {" ", "X", " ", "X", " ", "X", " " },
                {" ", "X", " ", "X", " ", " ", " " },
                {" ", "X", " ", "X", "X", "X", "X" }
            };

            FindMaxAreaOfEmptyCells(matrix);

            Console.WriteLine("Max area size: {0}", maxAreaCellsCount);
            PrintMatrix(maxAreaResult);
        }

        private static void FindMaxAreaOfEmptyCells(string[,] matrix)
        {
            for (int currentRow = 0; currentRow < matrix.GetLength(0); currentRow++)
            {
                for (int currentCol = 0; currentCol < matrix.GetLength(1); currentCol++)
                {
                    if (matrix[currentRow, currentCol] != "X")
                    {
                        matrix[currentRow, currentCol] = "O";
                        FindMaxAreaOfEmptyCells(matrix, currentRow, currentCol);
                        int currentCount = CountOfCells(matrix);

                        if (currentCount > maxAreaCellsCount)
                        {
                            maxAreaCellsCount = currentCount;
                            maxAreaResult = (string[,])matrix.Clone();
                        }

                        DeleteAllUsed(matrix);
                    }
                }
            }
        }

        private static void FindMaxAreaOfEmptyCells(string[,] matrix, int row = 0, int col = 0)
        {
            var currentCells = new List<Cell>();
            
            for (int i = 0; i < directions.GetLength(0); i++)
            {
                var nextRow = row + directions[i, 0];
                var nextCol = col + directions[i, 1];

                if (IsValidMove(matrix, nextRow, nextCol))
                {
                    matrix[nextRow, nextCol] = "O";
                    currentCells.Add(new Cell(nextRow, nextCol));
                }
            }

            foreach (var cell in currentCells)
            {
                FindMaxAreaOfEmptyCells(matrix, cell.Row, cell.Col);
            }
        }

        private static void DeleteAllUsed(string[,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r, c] == "O")
                    {
                        matrix[r, c] = " ";
                    }
                }
            }
        }

        private static int CountOfCells(string[,] matrix)
        {
            var count = 0;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r,c] == "O")
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public static bool IsValidMove(string[,] matrix, int row, int col)
        {
            if (row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1))
            {
                if (matrix[row, col] == " ")
                {
                    return true;
                }
            }

            return false;
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == "O")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write(matrix[i, j]);
                    Console.ResetColor();
                }

                Console.WriteLine();
            }
        }
    }
}
