using Chess.Pieces;

public class King : Piece
{
    public King(PieceColor color) 
        : base(color, new Position(File.E, color == PieceColor.White ? 1 : 8)) {}

    public King(PieceColor color, Position position) 
        : base(color, position) {}
}