using System;

namespace LCode.Array;

public class MaxVolumn
{
    // 左右两边 向中间移动短的一边
    public int MaxArea(int[] height)
    {
        int max = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left != right)
        {
            max = Math.Max(GetVolumn(left, height[left], right, height[right]), max);

            if (height[left] > height[right])
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return max;
    }

    // 正常的想法 一个个算 把潜在未来最大拿出来 如果比他更小后面就不用算了 进入下一个循环
    public int MaxArea2(int[] height)
    {
        int max = 0;
        for (int i = 0; i < height.Length - 1; i++)
        {
            if (CurrentPotentialMax(height[i], (height.Length - 1) - i) <= max)
            {
                continue;
            }

            for (int j = i + 1; j < height.Length; j++)
            {
                max = Math.Max(max, GetVolumn(i, height[i], j, height[j]));
            }
        }

        return max;
    }

    private int GetVolumn(int firstX, int firstHeight, 
        int secondX, int secondHeight)
    {
        return (secondX - firstX) * Math.Min(firstHeight, secondHeight);
    }

    private int CurrentPotentialMax(int currentHight, int maxWidth)
    {
        return currentHight * maxWidth;
    }
}