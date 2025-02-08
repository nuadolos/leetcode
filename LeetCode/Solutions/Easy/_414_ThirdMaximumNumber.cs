namespace LeetCode.Solutions.Easy;

public static class _414_ThirdMaximumNumber
{
    public static int Solution(int[] nums)
    {
        long first = long.MinValue, second = first, third = first;

        for (int i = 0; i < nums.Length; i++)
        {
            var numI = nums[i];

            if (first == numI || second == numI || third == numI)
                continue;

            if (numI > first)
            {
                third = second;
                second = first;
                first = numI;
            }
            else if (numI > second)
            {
                third = second;
                second = numI;
            }
            else if (numI > third)
            {
                third = numI;
            }
        }

        var result = third == long.MinValue
            ? (int)first
            : (int)third;

        return result;
    }
}
