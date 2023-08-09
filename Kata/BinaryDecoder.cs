using System.Collections;

namespace Kata.Tests;

public class BinaryDecoder
{
    public static List<int> Decode(List<BitArray> binaryCode)
    {
        var decodedNumbers =  new List<int>();
        foreach (var bitArray in binaryCode)
        {
            var number = 0;
            for (var i = 0; i < bitArray.Length; i++)
            {
                if (bitArray[i])
                {
                    number += (int) Math.Pow(2, i);
                }
            }
            decodedNumbers.Add(number);
        }
        return decodedNumbers;
    }
}