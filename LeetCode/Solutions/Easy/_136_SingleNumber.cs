namespace LeetCode.Solutions.Easy;

public static class _136_SingleNumber
{
    public static int Solution(int[] nums)
    {
        var result = 0;

        foreach (var num in nums)
        {
            result ^= num;
        }

        return result;
    }
}
