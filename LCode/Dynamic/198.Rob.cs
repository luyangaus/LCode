namespace LCode.Dynamic
{
    // 分为抢和不抢两种情况，抢了没不抢多还不如不抢
    // 所以分两个金额 抢和不抢
    // 抢过的下一轮不能抢所以 下一轮开始前要把抢和不抢的金额交换
    public class Rob
    {
        public int RobStart(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            else if (nums.Length == 2)
            {
                return nums[0] > nums[1] ? nums[0] : nums[1];
            }

            return MaxRob(nums);
        }

        private int MaxRob(int[] nums)
        {
            var result = new int[] { 0, 0 };
            foreach (var num in nums)
            {
                result[0] = result[0] + num;
                result = Swap(result);
            }

            return result[0] > result[1] ? result[0] : result[1];
        }

        private int[] Swap(int[] inArray)
        {
            var tou = inArray[0];
            var butou = inArray[1];

            if (butou > tou)
            {
                tou = butou;
            }

            return new int[] { butou, tou };
        }
    }
}