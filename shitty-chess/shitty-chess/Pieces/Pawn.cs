namespace shitty_chess;

public class Pawn : Piece
{
    public Pawn(PieceColor color)
    {
        LetterSymbol = 'P';
        PieceColor = color;
        FigureSymbol = color ==  PieceColor.White ? Symbols.WhitePawn : Symbols.BlackPawn;
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