using System;

namespace OceanLibrary
{
    public class MovedCellEventArgs : EventArgs
    {
        public MovedCellEventArgs(Coordinate newCoord, Cell oldCell)
        {
            NewCoord = newCoord;
            OldCell = oldCell;
        }

        public Coordinate NewCoord { get; private set; }

        public Cell OldCell { get; private set; }
    }
}
