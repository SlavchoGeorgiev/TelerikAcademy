namespace WalkInMatrix
{
    internal class TableCoordinatesHolder
    {
        internal TableCoordinatesHolder(int row, int column)
        {
            this.Row = row;
            this.Column = column;
        }

        internal int Row { get; set; }

        internal int Column { get; set; }
    }
}
