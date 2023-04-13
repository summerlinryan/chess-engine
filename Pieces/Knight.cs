using Chess.Pieces;

public class Knight : Piece
{
    public Knight(PieceColor color, File file) 
        : base(color, new Position(file, color == PieceColor.White ? 1 : 8)) {}

    public Knight(PieceColor color, Position position) 
        : base(color, position) {}
}