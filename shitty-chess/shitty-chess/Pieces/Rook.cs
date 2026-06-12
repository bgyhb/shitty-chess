namespace shitty_chess;

public class Rook : Piece
{
    public Rook(PieceColor color)
    {
        LetterSymbol = 'R';
        PieceColor = color;
        FigureSymbol = color == PieceColor.White ? Symbols.WhiteRook : Symbols.BlackRook;
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