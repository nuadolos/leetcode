namespace LeetCode.Solutions.Array.MonotonicArray;

public static class _896_MonotonicArray
{
    public static bool Solution(int[] nums)
    {
        if (nums.Length <= 2)
            return true;

        var prevNum = nums[0];

        bool? isIncreasing = null;
        for (int i = 1; i < nums.Length; i++)
        {
            var num = nums[i];

            if (prevNum < num)
            {
                if (isIncreasing == false)
                    return false;

                isIncreasing ??= true;
            }
            else if (prevNum > num)
            {
                if (isIncreasing == true)
                    return false;

                isIncreasing ??= false;
            }

            prevNum = num;
        }

        return true;
    }
}

public static class _896_MonotonicArrayTestCases
{
    public static int[] Test_1 { get; } = [1, 2, 2, 3];
    public static int[] Test_2 { get; } = [1, 3, 2];
}