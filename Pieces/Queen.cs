using Chess.Pieces;

public class Queen : Piece
{
    public Queen(PieceColor color) 
        : base(color, new Position(File.D, color == PieceColor.White ? 1 : 8)) {}

    public Queen(PieceColor color, Position position) 
        : base(color, position) {}
}