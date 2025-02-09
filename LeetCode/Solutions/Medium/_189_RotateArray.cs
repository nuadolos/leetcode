namespace LeetCode.Solutions.Medium;

public static class _189_RotateArray
{
    public static void Solution(int[] nums, int k)
    {
        var actLength = nums.Length;
        var actK = k % actLength;

        while (actK > 0)
        {
            for (var i = actK; i < actLength; i++)
            {
                var previous = i % actK;
                (nums[i], nums[previous]) = (nums[previous], nums[i]);
            }

            (actLength, actK) = (actK, actK - actLength % actK);
            actK %= actLength;
        }
    }
}
