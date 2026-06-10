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