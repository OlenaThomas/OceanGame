namespace OceanLibrary
{
    public interface IOcean
    {
        CellViewType this[int row, int column] { get; }
        int Height { get; }
        int Width { get; }
    }
}
