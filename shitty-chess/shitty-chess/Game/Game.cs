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
        _chessboard["a1"] = new Rook { Color = Color.White };
        _chessboard["b1"] = new Knight { Color = Color.White };
        _chessboard["c1"] = new Bishop { Color = Color.White };
        _chessboard["d1"] = new Queen { Color = Color.White };
        _chessboard["e1"] = new King { Color = Color.White };
        _chessboard["f1"] = new Bishop { Color = Color.White };
        _chessboard["g1"] = new Knight { Color = Color.White };
        _chessboard["h1"] = new Rook { Color = Color.White };
        
        _chessboard["a2"] = new Pawn { Color = Color.White };
        _chessboard["b2"] = new Pawn { Color = Color.White };
        _chessboard["c2"] = new Pawn { Color = Color.White };
        _chessboard["d2"] = new Pawn { Color = Color.White };
        _chessboard["e2"] = new Pawn { Color = Color.White };
        _chessboard["f2"] = new Pawn { Color = Color.White };
        _chessboard["g2"] = new Pawn { Color = Color.White };
        _chessboard["h2"] = new Pawn { Color = Color.White };
        
        _chessboard["a8"] = new Rook { Color = Color.Black };
        _chessboard["b8"] = new Knight { Color = Color.Black };
        _chessboard["c8"] = new Bishop { Color = Color.Black };
        _chessboard["d8"] = new Queen { Color = Color.Black };
        _chessboard["e8"] = new King { Color = Color.Black };
        _chessboard["f8"] = new Bishop { Color = Color.Black };
        _chessboard["g8"] = new Knight { Color = Color.Black };
        _chessboard["h8"] = new Rook { Color = Color.Black };
        
        _chessboard["a7"] = new Pawn { Color = Color.Black };
        _chessboard["b7"] = new Pawn { Color = Color.Black };
        _chessboard["c7"] = new Pawn { Color = Color.Black };
        _chessboard["d7"] = new Pawn { Color = Color.Black };
        _chessboard["e7"] = new Pawn { Color = Color.Black };
        _chessboard["f7"] = new Pawn { Color = Color.Black };
        _chessboard["g7"] = new Pawn { Color = Color.Black };
        _chessboard["h7"] = new Pawn { Color = Color.Black };
         
    }
}