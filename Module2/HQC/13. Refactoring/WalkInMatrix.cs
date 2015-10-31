namespace WalkInMatrix
{
    using System;

    public class WalkInMatrix
    {
        public static void Main()
        {
            Console.WriteLine("Enter a positive number ");
            string input = Console.ReadLine();
            int n = 0;
            while (!int.TryParse(input, out n) || n < 0 || n > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            // int n = 6;
            int[,] matrix = new int[n, n];
            int stepNumber = 0;
            var currentCell = new TableCoordinatesHolder(0, 0);
            var offset = new TableCoordinatesHolder(1, 1);
            
            while (true)
            {
                stepNumber++;
                matrix[currentCell.Row, currentCell.Column] = stepNumber;

                if (!HasFreeNeighborCell(matrix, currentCell.Row, currentCell.Column))
                {
                    currentCell = GetFirstFreeCell(matrix);
                    if (currentCell == null)
                    {
                        break;
                    }

                    offset.Row = 1;
                    offset.Column = 1;
                    continue;
                }

                bool isNextRowOutOfMatrix = currentCell.Row + offset.Row >= matrix.GetLength(0) || currentCell.Row + offset.Row < 0;
                bool isNextColOutOfMatrix = currentCell.Column + offset.Column >= matrix.GetLength(1) || currentCell.Column + offset.Column < 0;
                bool isNextCellOutOfMatrix = isNextRowOutOfMatrix || isNextColOutOfMatrix;
                while (isNextCellOutOfMatrix || matrix[currentCell.Row + offset.Row, currentCell.Column + offset.Column] != 0)
                {
                    offset = GetNextOffset(offset);

                    isNextRowOutOfMatrix = currentCell.Row + offset.Row >= matrix.GetLength(0) || currentCell.Row + offset.Row < 0;
                    isNextColOutOfMatrix = currentCell.Column + offset.Column >= matrix.GetLength(1) || currentCell.Column + offset.Column < 0;
                    isNextCellOutOfMatrix = isNextRowOutOfMatrix || isNextColOutOfMatrix;
                }

                currentCell.Row += offset.Row;
                currentCell.Column += offset.Column;
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static TableCoordinatesHolder GetNextOffset(TableCoordinatesHolder offset)
        {
            int[] rowOffsets = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] colOffsets = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int offsetIndex = 0;

            for (int i = 0; i < 8; i++)
            {
                if (rowOffsets[i] == offset.Row && colOffsets[i] == offset.Column)
                {
                    offsetIndex = i;

                    break;
                }
            }

            var rowOffset = rowOffsets[(offsetIndex + 1) % 8];
            var colOffset = colOffsets[(offsetIndex + 1) % 8];
            return new TableCoordinatesHolder(rowOffset, colOffset);
        }

        private static bool HasFreeNeighborCell(int[,] arr, int x, int y)
        {
            int[] rowOffsets = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] colOffsets = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                if (x + rowOffsets[i] >= arr.GetLength(0) || x + rowOffsets[i] < 0)
                {
                    rowOffsets[i] = 0;
                }

                if (y + colOffsets[i] >= arr.GetLength(0) || y + colOffsets[i] < 0)
                {
                    colOffsets[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (arr[x + rowOffsets[i], y + colOffsets[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static TableCoordinatesHolder GetFirstFreeCell(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        return new TableCoordinatesHolder(row, col);
                    }
                }
            }

            return null;
        }
    }
}
