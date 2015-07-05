namespace Minesweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Board
    {
        public static void AddResultToCellInBoards(char[,] userInterfaceBoard, char[,] boardWithMines, int row, int col)
        {
            char neighborMinesNumber = CalculateCountOfNeighborMines(boardWithMines, row, col);
            boardWithMines[row, col] = neighborMinesNumber;
            userInterfaceBoard[row, col] = neighborMinesNumber;
        }

        public static void Print(char[,] board)
        {
            int rowsNumber = board.GetLength(0);
            int colsNumber = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < rowsNumber; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < colsNumber; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        public static char[,] Generate()
        {
            int rows = 5;
            int cols = 10;
            char[,] board = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        public static char[,] GenerateWithMines()
        {
            const int Rows = 5;
            const int Cols = 10;
            const int NumberOfCells = Rows * Cols;
            const int MinesNumber = Rows + Cols;

            char[,] board = new char[Rows, Cols];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    board[i, j] = '-';
                }
            }

            List<int> minePositionCollection = new List<int>();
            Random randomGenerator = new Random();

            while (minePositionCollection.Count < MinesNumber)
            {
                int currentMine = randomGenerator.Next(NumberOfCells);

                if (!minePositionCollection.Contains(currentMine))
                {
                    minePositionCollection.Add(currentMine);
                }
            }

            foreach (int minePosition in minePositionCollection)
            {
                int col = minePosition / Cols;
                int row = minePosition % Cols;

                if (row == 0 && minePosition != 0)
                {
                    col--;
                    row = Cols;
                }
                else
                {
                    row++;
                }

                board[col, row - 1] = '*';
            }

            FillBoardWhiteSpacesWithCountOfNeighborMines(board);

            return board;
        }

        private static void FillBoardWhiteSpacesWithCountOfNeighborMines(char[,] board)
        {
            int colsNumber = board.GetLength(0);
            int rowsNumber = board.GetLength(1);

            for (int i = 0; i < colsNumber; i++)
            {
                for (int j = 0; j < rowsNumber; j++)
                {
                    if (board[i, j] != '*')
                    {
                        char countOfNeighborMines = CalculateCountOfNeighborMines(board, i, j);
                        board[i, j] = countOfNeighborMines;
                    }
                }
            }
        }

        private static char CalculateCountOfNeighborMines(char[,] boardWithMines, int row, int col)
        {
            int countOfNeighborMines = 0;
            int rowsNumber = boardWithMines.GetLength(0);
            int colsNumber = boardWithMines.GetLength(1);

            if (row - 1 >= 0)
            {
                if (boardWithMines[row - 1, col] == '*')
                {
                    countOfNeighborMines++;
                }
            }

            if (row + 1 < rowsNumber)
            {
                if (boardWithMines[row + 1, col] == '*')
                {
                    countOfNeighborMines++;
                }
            }

            if (col - 1 >= 0)
            {
                if (boardWithMines[row, col - 1] == '*')
                {
                    countOfNeighborMines++;
                }
            }

            if (col + 1 < colsNumber)
            {
                if (boardWithMines[row, col + 1] == '*')
                {
                    countOfNeighborMines++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (boardWithMines[row - 1, col - 1] == '*')
                {
                    countOfNeighborMines++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < colsNumber))
            {
                if (boardWithMines[row - 1, col + 1] == '*')
                {
                    countOfNeighborMines++;
                }
            }

            if ((row + 1 < rowsNumber) && (col - 1 >= 0))
            {
                if (boardWithMines[row + 1, col - 1] == '*')
                {
                    countOfNeighborMines++;
                }
            }

            if ((row + 1 < rowsNumber) && (col + 1 < colsNumber))
            {
                if (boardWithMines[row + 1, col + 1] == '*')
                {
                    countOfNeighborMines++;
                }
            }

            return char.Parse(countOfNeighborMines.ToString());
        }
    }
}
