namespace Chess.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(PieceColor color, File file) 
            : base(color, new Position(file, color == PieceColor.White ? 2 : 7)) {}

        public Pawn(PieceColor color, Position position) 
            : base(color, position) {}
    }
}