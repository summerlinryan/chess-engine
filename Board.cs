using Chess.Pieces;

public class Board 
{
    public List<Piece> Pieces { get; set; } = new();

    public IEnumerable<Piece> White => Pieces.Where(x => x.Color == PieceColor.White);

    public IEnumerable<Piece> Black => Pieces.Where(x => x.Color == PieceColor.Black);

    public PieceColor NextToMove { get; set; }

    public Board()
    {
        this.NextToMove = PieceColor.White;

        foreach (var pieceColor in Enum.GetValues<PieceColor>())
        {
            this.Pieces.AddRange(Enum.GetValues<File>().Select(f => new Pawn(pieceColor, f)));
            this.Pieces.Add(new Rook(pieceColor, File.A));
            this.Pieces.Add(new Rook(pieceColor, File.H));
            this.Pieces.Add(new Bishop(pieceColor, SquareColor.Light));
            this.Pieces.Add(new Bishop(pieceColor, SquareColor.Dark));
            this.Pieces.Add(new Knight(pieceColor, File.B));
            this.Pieces.Add(new Knight(pieceColor, File.G));
            this.Pieces.Add(new King(pieceColor));
            this.Pieces.Add(new Queen(pieceColor));
        }
    }
}
