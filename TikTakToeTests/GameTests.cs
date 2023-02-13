using TikTakToe;
using Xunit;

namespace CodeRetreat1;

public class GameTests
{
    [Fact]
    public void Start_Works()
    {
        Game game = new();
    }
    [Fact]
    public void GetPlayerOneCharacter_ReturnsCharacter()
    {
        Game game = new();

        var playerOneCharacter = game.GetPlayerOneCharacter();
        
        Assert.Equal('x',playerOneCharacter);
    }
    
    [Fact]
    public void GetPlayerTwoCharacter_ReturnsCharacter()
    {
        Game game = new();

        var playerTwoCharacter = game.GetPlayerTwoCharacter();
        
        Assert.Equal('o',playerTwoCharacter);
    }
    
    [Fact]
    public void PlayersHaveADifferentCharacter()
    {
        Game game = new Game();

        var playerOneCharacter = game.GetPlayerOneCharacter();
        var playerTwoCharacter = game.GetPlayerTwoCharacter();
        
        Assert.NotEqual(playerOneCharacter,playerTwoCharacter);
    }
}