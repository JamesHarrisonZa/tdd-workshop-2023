namespace FizzBuzz.Tests;

public class FizzBuzzTests
{
    [Fact]
    public void Create()
    {
        var fizzBuzz = new FizzBuzz();

        Assert.NotNull(fizzBuzz);
    }
}