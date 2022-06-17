using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var result = 0;
            ListNode current = new ListNode();
            ListNode head = new ListNode();
            head.next = current;
            do
            {
                var l1Value = l1?.val ?? 0;
                var l2Value = l2?.val ?? 0;

                result += l1Value + l2Value;

                var lastPosition = result % 10;
                current.val = lastPosition;
                ListNode temp;
                if (l1?.next is not null || l2?.next is not null || result > 9)
                {
                    temp = new ListNode();
                    current.next = temp;
                    current = temp;
                }

                l1 = l1?.next ?? null;
                l2 = l2?.next ?? null;

                result = result / 10;
            } while (l1 is not null || l2 is not null || result > 0);

            return head.next;
        }
    }
}
