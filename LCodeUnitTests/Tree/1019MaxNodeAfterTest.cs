using LCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCode.Tree;
using Xunit;

namespace LCodeUnitTests
{
    public class MaxNodeAfterTest
    {
        [Fact]
        public void TestCases()
        {
            //[2,1,5]
            var head = new MaxNodeAfter.ListNode(2, new MaxNodeAfter.ListNode(1, new MaxNodeAfter.ListNode(5, null)));
            var expected = new int[]{ 5, 5, 0 };
            var obj = new MaxNodeAfter();

            var result1 = obj.NextLargerNodes(head);
            
            Assert.Equal(expected, result1);
        }
    }
}