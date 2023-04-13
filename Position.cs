
public class Position
{
    public File File { get; }
    public int Rank { get; }

    public Position(File file, int rank) 
    {
        if (rank < 1 || rank > 8)
            throw new ArgumentOutOfRangeException(nameof(rank), rank, $"Rank must be between 1 and 8 inclusive.");

        File = file;
        Rank = rank;
    }
}
