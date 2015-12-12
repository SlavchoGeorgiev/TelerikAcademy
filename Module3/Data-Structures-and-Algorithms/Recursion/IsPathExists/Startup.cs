namespace FindAllPaths
{
    using System;
    using System.Linq;
    using System.Runtime.Remoting.Metadata.W3cXsd2001;

    public class Startup
    {
        private static void Main()
        {
            string[,] matrix = new string[,]
            {
                {"S", " ", " ", " ", " ", "X", " "},
                {" ", "X", " ", "X", "X", "X", " "},
                {" ", "X", " ", " ", " ", "X", " "},
                {" ", "X", " ", "X", "X", "X", " "},
                {" ", "X", " ", " ", " ", " ", "E"},
                {" ", "X", " ", "X", " ", "X", " "},
                {" ", " ", " ", "X", " ", " ", " "},
                {" ", "X", " ", " ", "X", "X", "X"}
            };

            IsPathExists(matrix, 0, 0, 0);

            string[,] bigMatrix = new string[100, 100];

            for (int i = 0; i < bigMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < bigMatrix.GetLength(1); j++)
                {
                    bigMatrix[i, j] = " ";
                }
            }

            bigMatrix[0, 0] = "S";
            bigMatrix[99, 99] = "E";

            IsPathExists(bigMatrix, 0, 0, 0);
        }

        public static bool IsPathExists(string[,] matrix, int row, int col, int direction)
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
                        return true;
                    }
                    else
                    {
                        MarkCurrentPosition(matrix, row, col, i);
                        if (IsPathExists(matrix, row + directions[i, 0], col + directions[i, 1], i))
                        {
                            return true;
                        }
                    }
                }
            }

            matrix[row, col] = " ";
            return false;
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
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('-', matrix.GetLength(1)));
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
