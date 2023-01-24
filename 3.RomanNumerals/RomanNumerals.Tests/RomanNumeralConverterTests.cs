namespace RomanNumerals.Tests;

public class RomanNumeralConverterTests
{
    [Fact]
    public void Create()
    {
        var romanNumeralConverter = new RomanNumeralConverter();

        Assert.NotNull(romanNumeralConverter);
    }
}