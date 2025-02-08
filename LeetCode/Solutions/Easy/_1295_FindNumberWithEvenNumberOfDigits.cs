namespace LeetCode.Solutions.Easy;

public static class _1295_FindNumberWithEvenNumberOfDigits
{
    public static int Solution(int[] nums)
    {
        int counter = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i].ToString().Length % 2 == 0)
                counter++;
        }

        return counter;
    }
}
