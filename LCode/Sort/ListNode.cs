using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCode.Sort
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
            next = null;
        }

        public String getResult()
        {
            String result = "" + val;
            while (next != null)
            {
                result += "->" + next.val;
                next = next.next;
            }
            result += "->null";
            return result;
        }
    }
}
