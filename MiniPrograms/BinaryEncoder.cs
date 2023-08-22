using System.Collections;

namespace Kata.Tests;

public class BinaryEncoder
{
    public static List<BitArray> Encode(List<int> numbers)
    {
        var encodedNumbers =  new List<BitArray>();
        foreach (var number in numbers)
        {
            encodedNumbers.Add(new BitArray(new[] {number}));
        }
        return encodedNumbers;
    }
}