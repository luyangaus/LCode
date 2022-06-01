using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCode.Sort
{
    /*
 *   插入排序 将数插入到 对应位置到排序
 *   61352 -> 16352 -> 13652 -> 13562 -> 12356
 *   例如第三步 处理到【3】 也就是 5 5比1 大比3大 比6 小 所以插入到3 和 6 之间
 *   61352 外部循环从头6到2 一次找数
 *
 *   建立一个新的头 0
 *   内部循环中将找的数
 *   和这个新的列表比较后插入适当的位子  06 -> 016 -> 0136 .....
 *
 *
 * 由于需要返回链的头 所以和头部的比较单独进行
 *
 * */

    public class InsertSort
    {
        /**
 * @param current: The first node of linked list.
 *
 * @return: The head of linked list.
 */
        public ListNode InsertionSortWithListNode(ListNode current)
        {
            //由于链的头可能会变 所以需要一个链头
            //之后会将结果插到新的头后面
            ListNode newStart = new ListNode(0);
            while (current != null)
            {
                ListNode loopNode = newStart;
                while (loopNode.next != null && loopNode.next.val < current.val)
                {
                    loopNode = loopNode.next;
                }

                ListNode currentNode = current.next;
                current.next = loopNode.next;
                loopNode.next = current;
                current = currentNode;
            }

            return newStart.next;
        }

        //array 的情况 比较位向前比较 参考video 关闭声音后打开 https://www.youtube.com/watch?v=8oJS1BMKE64
        public int[] InsertSortWithArray(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int sortedLastIndex = i - 1;
                int currentValue = array[i];
                while (sortedLastIndex >= 0 && currentValue < array[sortedLastIndex])
                {
                    array[sortedLastIndex + 1] = array[sortedLastIndex];
                    sortedLastIndex--;
                }
                array[sortedLastIndex + 1] = currentValue;
            }

            return array;
        }
    }
}
