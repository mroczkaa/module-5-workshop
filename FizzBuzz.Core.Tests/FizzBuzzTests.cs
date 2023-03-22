using Xunit;

namespace FizzBuzz.Core.Tests;

public class FizzBuzzTests
{

    private FizzBuzzService _fizzBuzzService;

    public FizzBuzzTests()
    {
        _fizzBuzzService = new FizzBuzzService();
    
    }

    [Fact]
    public void Should_Return_Number()
    {
        Assert.Equal("1", _fizzBuzzService.Print(1));
        Assert.Equal("2", _fizzBuzzService.Print(2));
    }
    [Fact]
    public void Should_Return_Fizz()
    {
        Assert.Equal("Fizz", _fizzBuzzService.Print(3));
        Assert.Equal("Fizz", _fizzBuzzService.Print(6));    
    }
    [Fact]
    public void Should_Return_Buzz()
    {
        Assert.Equal("Buzz", _fizzBuzzService.Print(5));
        Assert.Equal("Buzz", _fizzBuzzService.Print(10));
    }

    [Fact]
    public void Should_Return_FizzBuzz()
    {
        Assert.Equal("FizzBuzz", _fizzBuzzService.Print(15));
        Assert.Equal("FizzBuzz", _fizzBuzzService.Print(30));
    }
}