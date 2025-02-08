namespace LeetCode.Solutions.Easy;

public static class _905_SortArrayByParity
{
    public static int[] Solution(int[] nums)
    {
        var slow = 0;

        for (int fast = 0; fast < nums.Length; fast++)
        {
            var numFast = nums[fast];
            if (numFast % 2 != 0)
                continue;

            nums[fast] = nums[slow];
            nums[slow] = numFast;
            slow++;
        }

        return nums;
    }
}
