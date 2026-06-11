using Spectre.Console;

namespace shitty_chess;

public class Chessboard
{
    private readonly string [] lines = ["a","b","c","d","e","f","g","h"];
    private (string position, Piece? piece)[,] board = new (string, Piece?)[8,8];

    public (string position, Piece? piece)[,] Board
    {
        get
        {
            return board;
        }
        set
        {
            board = value;
        }
    }

    public Chessboard()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                board[i, j] = ($"{lines[j]}{8-i}", null);
            }
        }
    }

    public string this[int i, int j]
    {
        get => board[i, j].position;
    }

    public Piece? this[string position]
    {
        get
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (board[i, j].position == position) return board[i, j].piece;
                }
            }
            return null;
        }
        set
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (board[i, j].position == position) board[i, j].piece = value;
                }
            }
        }
    }

    public void Draw()
    {
        Style whiteSquare = new Style(background: Spectre.Console.Color.Gray);
        Style blackSquare = new Style(background: Spectre.Console.Color.Black);
        
        Table board =  new Table();
        board.Border(TableBorder.None).ShowRowSeparators = true;
        
        board.AddColumn(" ");
        board.AddColumn("[bold]a[/]");
        board.AddColumn("[bold]b[/]");
        board.AddColumn("[bold]c[/]");
        board.AddColumn("[bold]d[/]");
        board.AddColumn("[bold]e[/]");
        board.AddColumn("[bold]f[/]");
        board.AddColumn("[bold]g[/]");
        board.AddColumn("[bold]h[/]");
        
        bool isWhite = true;
        for (int i = 0; i < 8; i++)
        {
            Text [] row = new Text[9];
            row[0] = new Text($"{8 - i}", new Style(decoration: Decoration.Bold));
            
            for (int j = 0; j < 8; j++)
            {
                row[j+1] = isWhite ? new Text($"{Board[i, j].position}", whiteSquare) : 
                                     new Text($"{Board[i, j].position}", blackSquare);
                isWhite = !isWhite;
            }
            
            board.AddRow(row);
            isWhite = !isWhite;
        }
        
        AnsiConsole.Write(board);
    }

    public override string ToString()
    {
        string result = "";
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                result += Board[i, j] + " ";
            }
            result += Environment.NewLine;
        }
        return result;
    }
}