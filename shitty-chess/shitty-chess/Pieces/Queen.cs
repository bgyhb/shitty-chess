namespace shitty_chess;

public class Queen : Piece
{
    public Queen(PieceColor color)
    {
        LetterSymbol = 'Q';
        PieceColor = color;
        FigureSymbol = color == PieceColor.White ? Symbols.WhiteQueen : Symbols.BlackQueen;
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