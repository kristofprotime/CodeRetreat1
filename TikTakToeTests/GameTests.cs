using TikTakToe;
using Xunit;

namespace CodeRetreat1;

public class GameTests
{
    private readonly Game game;

    public GameTests()
    {
        game = new Game();
    }

    [Fact]
    public void Start_Works()
    {
        Game game = new();
    }

    [Fact]
    public void GetPlayerOneCharacter_ReturnsCharacter()
    {
        var playerOneCharacter = game.GetPlayerOneCharacter();
        
        Assert.Equal('x',playerOneCharacter);
    }
    
    [Fact]
    public void GetPlayerTwoCharacter_ReturnsCharacter()
    {
        var playerTwoCharacter = game.GetPlayerTwoCharacter();
        
        Assert.Equal('o',playerTwoCharacter);
    }
    
    [Fact]
    public void PlayersHaveADifferentCharacter()
    {
        var playerOneCharacter = game.GetPlayerOneCharacter();
        var playerTwoCharacter = game.GetPlayerTwoCharacter();
        
        Assert.NotEqual(playerOneCharacter,playerTwoCharacter);
    }

    [Fact]
    public void GameHasA2DimensionalBoard()
    {
        var board = game.GetBoard();

        Assert.NotNull(board);
        Assert.Equal(typeof(Char[][]), board.GetType());
    }
}