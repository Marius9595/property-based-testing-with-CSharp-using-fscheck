namespace Kata.biggest_number;

public class BiggestNumber
{
    public static int FindBiggestNumber(List<int> numbers)
    {
        var biggestNumber = numbers[0];
        foreach (var number in numbers)
        {
            if (biggestNumber < number)
            {
                biggestNumber = number;
            }
        }
        return biggestNumber;
    }
}