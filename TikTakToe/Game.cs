namespace TikTakToe;

public class Game
{
    public object GetBoard()
    {
        return new Char[0][];
    }

    public char GetPlayerOneCharacter()
    {
        return 'x';
    }
    
    public char GetPlayerTwoCharacter()
    {
        return 'o';
    }
}