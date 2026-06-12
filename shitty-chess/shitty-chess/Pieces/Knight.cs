namespace shitty_chess;

public class Knight : Piece
{
    public Knight(PieceColor color)
    {
        LetterSymbol = 'N';
        PieceColor = color;
        FigureSymbol = color ==  PieceColor.White ? Symbols.WhiteKnight : Symbols.BlackKnight;
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