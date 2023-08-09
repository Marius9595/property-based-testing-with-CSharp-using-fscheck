using Kata.biggest_number;

namespace Kata.Tests;
using FluentAssertions;
using FsCheck;
using FsCheck.Fluent;
using FsCheck.Xunit;

public class ListSorterShould
{
    [Property]  
    public Property ASortedListHasOrderedPairs()  
    {  
        var generatorOfListOfNumbers = (  
            Gen.Choose(int.MinValue, int.MaxValue).NonEmptyListOf().ToArbitrary()  
        );
        return Prop.ForAll(generatorOfListOfNumbers,numbers =>  
            {
                var sortedNumbers = ListSorter.Sort(numbers);
                IsOrdered(sortedNumbers).Should().BeTrue();
            }
        );  
    }
    
    static bool IsOrdered(List<int> numbers)
    {
        if (numbers.Count >= 2)
        {
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i - 1] > numbers[i])
                {
                    return false;
                }
            }
        }
        
        return true;
    }
    
    [Property]  
    public Property ASortedListAndUnsortedListHasBothTheSameSize()  
    {  
        var generatorOfListOfNumbers = (  
            Gen.Choose(int.MinValue, int.MaxValue).NonEmptyListOf().ToArbitrary()  
        );
        return Prop.ForAll(generatorOfListOfNumbers,numbers =>  
            {
                var sortedNumbers = ListSorter.Sort(numbers);
                sortedNumbers.Count.Should().Be(numbers.Count);
            }
        );  
    }
}