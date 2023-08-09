using FluentAssertions;
using FsCheck;
using FsCheck.Fluent;
using FsCheck.Xunit;
using Kata.biggest_number;

namespace Kata.Tests;

public class LastNumberShould
{
    [Fact]
    public void PickTheLastNumber__ExampleBased()
    {
        var knowNumber = 5;
        var numbers = new List<int> {1, 2, 3, 4, knowNumber};
        var lastNumber = LastNumber.FindLastNumber(numbers);
        lastNumber.Should().Be(knowNumber);
    }
}