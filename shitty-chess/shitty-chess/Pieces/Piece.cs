namespace shitty_chess;

public abstract class Piece
{
    public char LetterSymbol { get; init; }
    public char FigureSymbol { get; init; }
    public PieceColor PieceColor {get; init;}
    
    public abstract List<string> GetPossibleMoves();
    public abstract void Move();

    public override string ToString()
    {
        return $"{FigureSymbol}";
    }
}