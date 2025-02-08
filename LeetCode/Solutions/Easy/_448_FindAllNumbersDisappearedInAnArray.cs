namespace LeetCode.Solutions.Easy;

public static class _448_FindAllNumbersDisappearedInAnArray
{
    public static IList<int> Solution(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int index = Math.Abs(nums[i]) - 1;
            if (nums[index] > 0) nums[index] = -nums[index];
        }

        var result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0) result.Add(i + 1);
        }

        return result;
    }
}
