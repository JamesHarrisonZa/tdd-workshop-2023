namespace BowlingGame.Tests;

public class BowlingGameTests
{
    [Fact]
    public void Create()
    {
        var bowlingGame = new BowlingGame();

        Assert.NotNull(bowlingGame);
    }
}