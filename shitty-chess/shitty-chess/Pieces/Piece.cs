namespace shitty_chess;

public abstract class Piece
{
    public char Symbol { get; init; }
    public required Color Color {get; init;}
    
    public abstract List<string> GetPossibleMoves();
    public abstract void Move();

    public override string ToString()
    {
        return $"{Symbol}";
    }
}