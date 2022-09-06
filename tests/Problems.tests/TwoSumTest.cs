using System.Collections.Generic;
using Problems.TwoSumN;
using Xunit;

namespace Problems.tests;

internal class TwoSumValueObject
{
    public int[] input {get; set;}
    public int target {get; set;}
    public int[] expected {get; set;}
}

public class TwoSumTest
{
    // Arrange
    List<TwoSumValueObject> testObjects = new List<TwoSumValueObject>()
    {
        new TwoSumValueObject
        {
            input = new int[4] {2, 7, 11, 15},
            target = 9,
            expected = new int[2] {0, 1}
        },
        new TwoSumValueObject
        {
            input = new int[3] {3, 2, 4},
            target = 6,
            expected = new int[2] {1, 2}
        },
        new TwoSumValueObject
        {
            input = new int[2] {3, 3},
            target = 6,
            expected = new int[2] {0, 1}
        }
    };

    [Fact]
    public void TestBruteForce()
    {
        // Act/Assert
        foreach (var testObject in testObjects)
        {
            Assert.Equal(testObject.expected, TwoSum.BruteForce(testObject.input, testObject.target));
        }
    }

    [Fact]
    public void TestHashMap()
    {
        // Act/Assert
        foreach (var testObject in testObjects)
        {
            Assert.Equal(testObject.expected, TwoSum.HashMap(testObject.input, testObject.target));
        }
    }


}