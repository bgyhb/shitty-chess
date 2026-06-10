namespace shitty_chess.Game;

public static class ConsoleHelper
{
    private const char whiteBlock = '\u2588';
    private static string whiteSquare = whiteBlock.ToString() + whiteBlock.ToString();
    public static void DrawBoard()
    {
        bool white = true;
        string result = "";
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                result += white ? whiteSquare + " " : "   ";
                white = !white;
            }
            result += Environment.NewLine;
            white = !white;
        }
        
        Console.WriteLine(result);
    }
}