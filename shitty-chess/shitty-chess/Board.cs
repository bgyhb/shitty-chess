namespace shitty_chess;

public class Board
{
    private readonly string [] lines = ["a","b","c","d","e","f","g","h"];
    public readonly string [,] TheBoard = new string[8,8];

    public Board()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                TheBoard[i, j] = $"{lines[j]}{8-i}";
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
                result += TheBoard[i, j] + " ";
            }
            result += Environment.NewLine;
        }
        return result;
    }
}