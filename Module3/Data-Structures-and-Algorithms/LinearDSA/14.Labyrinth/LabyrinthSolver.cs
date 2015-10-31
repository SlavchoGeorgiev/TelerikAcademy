namespace _14.Labyrinth
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public class LabyrinthSolver
    {
        private string[,] labyrinth;

        private PointInMatrix startPoint = new PointInMatrix();

        public LabyrinthSolver(string[,] labyrinth)
        {
            this.labyrinth = (string[,])labyrinth.Clone();
            if (!this.InitialiseStartPoint(this.labyrinth))
            {
                throw new ArgumentException("Labyrinth do not contains expected start point.");
            }
        }
        
        public string[,] Solve()
        {
            this.InitializeNeighbors(new List<PointInMatrix>() { this.startPoint });

            this.ReplaceZeroWtihU();

            return this.labyrinth;
        }

        private void ReplaceZeroWtihU()
        {
            for (int row = 0; row < this.labyrinth.GetLength(0); row++)
            {
                for (int col = 0; col < this.labyrinth.GetLength(1); col++)
                {
                    if (this.labyrinth[row, col] == "0")
                    {
                        this.labyrinth[row, col] = "u";
                    }
                }
            }
        }

        private void InitializeNeighbors(List<PointInMatrix> pointsInMatrix)
        {
            var listOfAddedPoints = new List<PointInMatrix>();

            foreach (var point in pointsInMatrix)
            {
                var currentPointNeighbors = new List<PointInMatrix>()
                {
                  new PointInMatrix() { Col = point.Col, Row = point.Row - 1 },
                  new PointInMatrix() { Col = point.Col, Row = point.Row + 1 },
                  new PointInMatrix() { Col = point.Col - 1, Row = point.Row },
                  new PointInMatrix() { Col = point.Col + 1, Row = point.Row }
                };

                int nextPathLenght;

                if (point.Equals(this.startPoint))
                {
                    nextPathLenght = 1;
                }
                else
                {
                    nextPathLenght = int.Parse(this.labyrinth[point.Row, point.Col]) + 1;
                }

                foreach (var neighborPoint in currentPointNeighbors)
                {
                    if (this.IsValidNextPoint(neighborPoint))
                    {
                        this.labyrinth[neighborPoint.Row, neighborPoint.Col] = nextPathLenght.ToString();
                        listOfAddedPoints.Add(neighborPoint);
                    }
                }
            }

            if (listOfAddedPoints.Count > 0)
            {
                this.InitializeNeighbors(listOfAddedPoints);
            }
        }

        private bool IsValidNextPoint(PointInMatrix point)
        {
            if (point.Row >= 0 &&
                point.Col >= 0 &&
                point.Row < this.labyrinth.GetLength(0) &&
                point.Col < this.labyrinth.GetLength(1))
            {
                if (this.labyrinth[point.Row, point.Col] == "0")
                {
                    return true;
                }
            }

            return false;
        }
        
        private bool InitialiseStartPoint(string[,] labyrinth)
        {
            for (int row = 0; row < labyrinth.GetLength(0); row++)
            {
                for (int col = 0; col < labyrinth.GetLength(1); col++)
                {
                    if (labyrinth[row, col] == "*")
                    {
                        this.startPoint.Row = row;
                        this.startPoint.Col = col;
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
