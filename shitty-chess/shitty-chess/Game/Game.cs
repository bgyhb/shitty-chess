namespace shitty_chess.Game;

public class Game
{
    private Chessboard _chessboard;
    public Game(Chessboard chessboard)
    {
        _chessboard = chessboard;
        SetInitialPositions();
    }

    private void SetInitialPositions()
    {
        _chessboard["a1"] = new Rook(PieceColor.White);
        _chessboard["b1"] = new Knight(PieceColor.White);
        _chessboard["c1"] = new Bishop(PieceColor.White);
        _chessboard["d1"] = new Queen(PieceColor.White);
        _chessboard["e1"] = new King(PieceColor.White);
        _chessboard["f1"] = new Bishop(PieceColor.White);
        _chessboard["g1"] = new Knight(PieceColor.White);
        _chessboard["h1"] = new Rook(PieceColor.White);
        
        _chessboard["a2"] = new Pawn(PieceColor.White);
        _chessboard["b2"] = new Pawn(PieceColor.White);
        _chessboard["c2"] = new Pawn(PieceColor.White);
        _chessboard["d2"] = new Pawn(PieceColor.White);
        _chessboard["e2"] = new Pawn(PieceColor.White);
        _chessboard["f2"] = new Pawn(PieceColor.White);
        _chessboard["g2"] = new Pawn(PieceColor.White);
        _chessboard["h2"] = new Pawn(PieceColor.White);
        
        _chessboard["a8"] = new Rook(PieceColor.Black);
        _chessboard["b8"] = new Knight(PieceColor.Black);
        _chessboard["c8"] = new Bishop(PieceColor.Black);
        _chessboard["d8"] = new Queen(PieceColor.Black);
        _chessboard["e8"] = new King(PieceColor.Black);
        _chessboard["f8"] = new Bishop(PieceColor.Black);
        _chessboard["g8"] = new Knight(PieceColor.Black);
        _chessboard["h8"] = new Rook(PieceColor.Black);
        
        _chessboard["a7"] = new Pawn(PieceColor.Black);
        _chessboard["b7"] = new Pawn(PieceColor.Black);
        _chessboard["c7"] = new Pawn(PieceColor.Black);
        _chessboard["d7"] = new Pawn(PieceColor.Black);
        _chessboard["e7"] = new Pawn(PieceColor.Black);
        _chessboard["f7"] = new Pawn(PieceColor.Black);
        _chessboard["g7"] = new Pawn(PieceColor.Black);
        _chessboard["h7"] = new Pawn(PieceColor.Black);
         
    }
}