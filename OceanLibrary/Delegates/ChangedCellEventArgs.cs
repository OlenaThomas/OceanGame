using System;

namespace OceanLibrary
{
    public class ChangedCellEventArgs : EventArgs
    {
        public ChangedCellEventArgs(Cell target)
        {
            Target = target;
        }

        public Cell Target { get; private set; }
    }
}
