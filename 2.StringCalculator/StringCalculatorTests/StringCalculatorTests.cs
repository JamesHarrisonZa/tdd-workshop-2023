namespace StringCalculator.Tests;

public class StringCalculatorTests
{
    [Fact]
    public void Create()
    {
        var stringCalculator = new StringCalculator();

        Assert.NotNull(stringCalculator);
    }
}
