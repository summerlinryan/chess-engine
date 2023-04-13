using Chess.Pieces;

public class Bishop : Piece
{
    public Bishop(PieceColor pieceColor, SquareColor squareColor) 
        : base (pieceColor, new Position(GetBishopFile(pieceColor, squareColor), pieceColor == PieceColor.White ? 1 : 8)) {}

    public Bishop(PieceColor pieceColor, Position position) 
        : base(pieceColor, position) {}

    public static File GetBishopFile(PieceColor pieceColor, SquareColor squareColor)
    {
        return pieceColor switch
        {
            PieceColor.White => squareColor == SquareColor.Light ? File.F : File.C,
            PieceColor.Black => squareColor == SquareColor.Dark ? File.F : File.C,
            _ => throw new ArgumentOutOfRangeException(nameof(pieceColor), pieceColor, $"{nameof(pieceColor)} must be {PieceColor.White} or {PieceColor.Black}")
        };
    }
}