using FluentAssertions;
using FsCheck;
using FsCheck.Fluent;
using FsCheck.Xunit;
using Kata.biggest_number;

namespace Kata.Tests;

public class BiggestNumberShould
{
    
    [Property]
    public Property FindsBiggestNumber()
    {
        var generatorOfListOfNumbers = (
            Gen.Choose(int.MinValue, int.MaxValue).NonEmptyListOf().ToArbitrary()
        );
        return Prop.ForAll(generatorOfListOfNumbers, numbers =>
        {
            var biggestNumber = BiggestNumber.FindBiggestNumber(numbers);
            biggestNumber.Should().Be(numbers.Max());
        });
    }
}
