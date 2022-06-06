using LCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LCodeUnitTests
{
    public class TwoSumTests
    {
        [Fact]
        public void TestCases()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var expect = new int[] { 0, 1 };

            var result1 = OneTwoSum.TwoSum(nums, target);

            Assert.Equal(expect, result1);
        }
    }
}
