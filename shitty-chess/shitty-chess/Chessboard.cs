using Spectre.Console;

namespace shitty_chess;

public class Chessboard
{
    private readonly string [] lines = ["a","b","c","d","e","f","g","h"];
    public static readonly string [,] Board = new string[8,8];

    public Chessboard()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Board[i, j] = $"{lines[j]}{8-i}";
            }
        }
    }

    public void DrawBoard()
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
                row[j+1] = isWhite ? new Text($"{Board[i, j]}", whiteSquare) : new Text($"{Board[i, j]}", blackSquare);
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