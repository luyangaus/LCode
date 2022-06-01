using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCode.Sort
{
    public class MergeSort
    {
        public void MergeSortProcess(int[] array)
        {
            int[] temp = new int[array.Length];
            ChopArray(array, temp, 0, array.Length - 1);
        }

        private void ChopArray(int[] array, int[] temp, int start, int end)
        {
            if (start == end)
            {
                return;
            }

            int mid = (start + end) / 2;
            ChopArray(array, temp, start, mid);
            ChopArray(array, temp, mid + 1, end);
            MergeSortLogic(array, temp, start, mid, end);
        }

        private void MergeSortLogic(int[] array, int[] temp, int start, int mid, int end)
        {
            int indexOfLeftArray = start;
            int indexOfRightArray = mid + 1;
            int indexOfTempArray = start;
            while (indexOfLeftArray <= mid && indexOfRightArray <= end)
            {
                if (array[indexOfLeftArray] < array[indexOfRightArray])
                {
                    temp[indexOfTempArray++] = array[indexOfLeftArray++];
                }
                else
                {
                    temp[indexOfTempArray++] = array[indexOfRightArray++];
                }
            }

            //there might be left number in left or right
            while (indexOfLeftArray <= mid)
            {
                temp[indexOfTempArray++] = array[indexOfLeftArray++];
            }

            while (indexOfRightArray <= end)
            {
                temp[indexOfTempArray++] = array[indexOfRightArray++];
            }

            //把合并好的数放到原来的数组
            for (int i = start; i <= end; i++)
            {
                array[i] = temp[i];
            }
        }
    }
}
