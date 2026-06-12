namespace shitty_chess;

public class King : Piece
{
    public King(PieceColor color)
    {
        LetterSymbol = 'K';
        PieceColor = color;
        FigureSymbol = color == PieceColor.White ? Symbols.WhiteKing : Symbols.BlackKing;
    }
    public override List<string> GetPossibleMoves()
    {
        throw new NotImplementedException();
    }

    public override void Move()
    {
        throw new NotImplementedException();
    }
}