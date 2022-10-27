using System;

namespace LCode.Array;

public class RainWater {
    // 类似于 MaxVolumn 算最外墙里的体积 墙像内部移动时候减去石头 + 更高的墙内的水
    public int Trap(int[] height)
    {
        int maxHeight = 0;
        int left = 0;
        int right = height.Length - 1;
        var volumn = 0;
        while (left != right)
        {
            if (height[left] > maxHeight && height[right] > maxHeight)
            {
                volumn += GetValumn(left, (height[left] - maxHeight), right, (height[right] - maxHeight));
                maxHeight = Math.Min(height[left], height[right]);
            }

            if (height[left] >= height[right])
            {
                right--;
                if (left != right)
                    volumn -= Math.Min(height[right], maxHeight);
            }
            else
            {
                left++;
                if (left != right)
                    volumn -= Math.Min(height[left], maxHeight);
            }
        }

        return volumn;
    }

        public int GetValumn(int left, int leftHeight, int right, int rightHeight)
        {
            return (right - left -1) * Math.Min(leftHeight, rightHeight);
        }
}