using LCode;
using LCode._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LCodeUnitTests
{
    public class a2AddTwoNumbersTest
    {
        [Fact]
        public void AddTwoNumbers_Test_OverInt() 
        {
            // Arrange
            ListNode listNode1 = new ListNode(9);
            ListNode listNode2 = new ListNode(1);

            ListNode lastNode = listNode2;
            for (var i = 0; i < 9; i++)
            {
                var current = new ListNode(9);
                lastNode.next = current;
                lastNode = current;
            }
            ListNode expectCurrent;

            // Action
            AddTwoNumbersSolution solution = new AddTwoNumbersSolution();
            var result = solution.AddTwoNumbers(listNode1, listNode2);

            // Assert
            expectCurrent = result;
            for (int index = 0; index < 11; index++)
            {
                if (index != 10)
                    Assert.Equal(0,expectCurrent.val);
                else
                    Assert.Equal(1,expectCurrent.val);

                expectCurrent = expectCurrent.next;
            }
        }

        [Fact]
        public void AddTwoNumbers_Test_JinWei()
        { 
            var listNode1 = new ListNode(9);
           var listNode2 = new ListNode(1);

            var result = new AddTwoNumbersSolution().AddTwoNumbers(listNode1, listNode2);
            Assert.Equal(0,result.val);
            Assert.Equal(1,result.next.val);
        }
    }
}
