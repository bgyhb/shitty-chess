using shitty_chess.Game;

namespace shitty_chess;

class Program
{
    static void Main(string[] args)
    {
        Chessboard chessboard = new Chessboard();
        Game.Game game = new Game.Game(chessboard);
        
        chessboard.Draw();
    }
}