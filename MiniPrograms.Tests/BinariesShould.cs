namespace Kata.Tests;
using FluentAssertions;
using FsCheck;
using FsCheck.Fluent;
using FsCheck.Xunit;


public class BinariesShould
{
    [Property]  
    public Property SymmetricEncodingDecoding()  
    {  
        var generatorOfListOfNumbers = (  
            Gen.Choose(int.MinValue, int.MaxValue).NonEmptyListOf().ToArbitrary()  
        );
        return Prop.ForAll(generatorOfListOfNumbers,numbers =>  
            {
                var encodeNumbers = BinaryEncoder.Encode(numbers);
                var decodeNumbers = BinaryDecoder.Decode(encodeNumbers);
                decodeNumbers.Should().BeEquivalentTo(numbers);
            }
        );  
    }
}