using LCode.Dynamic;
using Xunit;

namespace LCodeUnitTests.Dynamic
{
    public class RobTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2 }, 2)]
        [InlineData(new int[] { 2, 1, 1, 2 }, 4)]
        [InlineData(new int[] { 1, 7, 8, 3 }, 10)]
        [InlineData(new int[] { 7, 7, 2, 1 }, 9)]
        public void TestCases(int[] house, int expected)
        {
            // arrange
            Rob rob = new Rob();

            // action
            var result = rob.RobStart(house);

            // assert
            Assert.Equal(expected, result);
        }
    }
}