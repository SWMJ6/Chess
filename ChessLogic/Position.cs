﻿namespace ChessLogic
{
    public class Position
    {
        public int Row { get; }
        public int Column { get; }

        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }
        public player SquareColor()
        {


            if ((Row + Column) % 2== 0)
            {
                return player.White;
            }
            return player.Black;
        }

        public override bool Equals(object obj)
        {
            return obj is Position position &&
                   Row == position.Row &&
                   Column == position.Column;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Column);
        }

        public static bool operator ==(Position left, Position right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);
        }

        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }

        public static Position operator +(Position pos, Direction dir)
        {

            return new Position(pos.Row + dir.RowDelta, pos.Column + dir.ColumnDelta);
        }

    }
}
