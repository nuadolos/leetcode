namespace LeetCode.Solutions.Medium;

public static class _209_MinimumSizeSubarraySum
{
    public static int Solution(int target, int[] nums)
    {
        var left = 0;
        var sum = 0;
        var minLength = nums.Length + 1;

        for (var right = 0; right < nums.Length; right++)
        {
            sum += nums[right];

            while (sum >= target)
            {
                minLength = Math.Min(minLength, right - left + 1);
                sum -= nums[left];
                left++;
            }
        }

        return minLength > nums.Length
            ? 0
            : minLength;
    }
}
