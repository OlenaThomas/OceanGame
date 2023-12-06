namespace OceanLibrary
{
    public struct Coordinate
    {
        #region --== fields==--

        public int _row;
        public int _column;

        #endregion

        #region --==constructor==--

        public Coordinate(int row, int column)
        {
            _row = row;
            _column = column;
        }

        #endregion

        #region --==properties==--

        public int Row
        {
            get
            {
                return _row;
            }
        }

        public int Column
        {
            get
            {
                return _column;
            }
        }

        #endregion
    }
}
