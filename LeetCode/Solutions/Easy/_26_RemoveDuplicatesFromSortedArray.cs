namespace LeetCode.Solutions.Easy;

public static class _26_RemoveDuplicatesFromSortedArray
{
    public static int Solution(int[] nums)
    {
        var writeIndex = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[writeIndex] == nums[i])
                continue;

            nums[++writeIndex] = nums[i];
        }

        return writeIndex + 1;
    }
}
