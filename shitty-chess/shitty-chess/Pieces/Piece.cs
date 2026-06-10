namespace shitty_chess;

public abstract class Piece
{
    public required string Square {get; set;}
    public required char Symbol {get; init;}
    public required Color Color {get; init;}
    
    private Chessboard _chessboard;
    public Piece(Chessboard chessboard)
    {
        _chessboard = chessboard;
    }
    
    public abstract List<string> GetPossibleMoves();
    public abstract void Move();
}