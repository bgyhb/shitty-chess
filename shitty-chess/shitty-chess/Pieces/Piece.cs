namespace shitty_chess;

public abstract class Piece
{
    public required string Square {get; set;}
    public required char Symbol {get; init;}
    public required Color Color {get; init;}
    
    public abstract List<string> GetPossibleMoves(Board board);
}