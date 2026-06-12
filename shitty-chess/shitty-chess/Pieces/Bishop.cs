namespace shitty_chess;

public class Bishop : Piece
{
    public Bishop(PieceColor color)
    {
        LetterSymbol = 'B';
        PieceColor = color;
        FigureSymbol = color == PieceColor.White ? Symbols.WhiteBishop : Symbols.BlackBishop;
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