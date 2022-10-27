using LCode.Array;
using Xunit;

namespace LCodeUnitTests.Array;

public class RainWaterTests {
    [Fact]
    public void TestCases()
    {
        var input = new int[] { 0,1,0,2,1,0,1,3,2,1,2,1 };
        var expect = 6;

        var rain = new RainWater();
        var result1 = rain.Trap(input);

        Assert.Equal(expect, result1);
    }
}