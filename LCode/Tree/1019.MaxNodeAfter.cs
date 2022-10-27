using System;
using System.Collections;
using System.Collections.Generic;

namespace LCode.Tree;

public class MaxNodeAfter
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

    public int[] NextLargerNodes(ListNode head)
    {
        var reversedList = ReverseList(head);
        var resultList = new List<int>();
        int maxInt = Int32.MinValue;
        while (reversedList != null)
        {
            if (resultList.Count == 0)
            {
                resultList.Add(0);
                maxInt = reversedList.val;
            }
            else if (maxInt > reversedList.val)
            {
                resultList.Add(maxInt);
            }
            else
            {
                resultList.Add(0);
                maxInt = reversedList.val;
            }

            reversedList = reversedList.next;
        }

        resultList.Reverse();

        return resultList.ToArray();
    }

    private ListNode ReverseList(ListNode head)
    {
        ListNode newEnd = null;
        while (head != null)
        {
            var current = head.next;
            head.next = newEnd;
            newEnd = head;
            head = current;
        }

        return newEnd;
    }
}