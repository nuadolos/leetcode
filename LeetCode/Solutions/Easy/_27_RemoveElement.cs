namespace LeetCode.Solutions.Easy;

public static class _27_RemoveElement
{
    public static int Solution(int[] nums, int val)
    {
        int writeIndex = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
                continue;

            nums[writeIndex] = nums[i];
            writeIndex++;
        }

        return writeIndex;
    }
}
