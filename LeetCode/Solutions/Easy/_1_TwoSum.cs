namespace LeetCode.Solutions.Easy;

public static class _1_TwoSum
{
    public static int[] Solution(int[] nums, int target)
    {
        var dictionary = new Dictionary<int, int>();

        for (int firstIndex = 0; firstIndex < nums.Length; firstIndex++)
        {
            var num = nums[firstIndex];
            if (dictionary.TryGetValue(target - num, out var secondIndex))
                return [firstIndex, secondIndex];

            dictionary[num] = firstIndex;
        }

        throw new NotSupportedException();
    }
}
