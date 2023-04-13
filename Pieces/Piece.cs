namespace Chess.Pieces
{
    public class Piece
    {
        public PieceColor Color { get; }

        public Position Position { get; }

        public SquareColor SquareColor => 
            (IsOdd((int) Position.File) && IsOdd(Position.Rank)) || 
            (IsEven((int)Position.File) && IsEven(Position.Rank)) 
                ? SquareColor.Dark 
                : SquareColor.Light;

        public Piece(PieceColor color, Position position)
        {
            Color = color;
            Position = position;
        }

        public static bool IsEven(int n) => n % 2 == 0;
        
        public static bool IsOdd(int n) => n % 2 != 0;
    }
}