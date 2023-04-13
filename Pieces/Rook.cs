using Chess.Pieces;

public class Rook : Piece
{
    public Rook(PieceColor color, File file)
        : base(color, new Position(file, color == PieceColor.White ? 1 : 8)) {}

    public Rook(PieceColor color, Position position) 
        : base(color, position) {}
}