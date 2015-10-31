namespace _14.Labyrinth
{
    using System;

    public struct PointInMatrix : IEquatable<PointInMatrix>
    {
        public int Row { get; set; }

        public int Col { get; set; }

        public bool Equals(PointInMatrix other)
        {
            if (this.Row == other.Row && this.Col == other.Col)
            {
                return true;
            }

            return false;
        }
    }
}
