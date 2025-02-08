namespace LeetCode.Solutions.Easy;

public static class _724_FindPivotIndex
{
    public static int Solution(int[] nums)
    {
        var sumLeft = 0;

        var sumRight = 0;
        for (int i = 0; i < nums.Length; i++)
            sumRight += nums[i];

        for (int i = 0; i < nums.Length; i++)
        {
            sumRight -= nums[i];

            if (sumLeft == sumRight)
                return i;

            sumLeft += nums[i];
        }

        return -1;
    }
}
