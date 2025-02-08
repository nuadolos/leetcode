namespace LeetCode.Solutions.Easy;

public static class _977_SquaresOfSortedArray
{
    public static int[] Solution(int[] nums)
    {
        int left = 0, right = nums.Length - 1, currentIndex = right;

        var result = new int[nums.Length];
        while (left <= right)
        {
            var leftValue = nums[left];
            var leftSquare = leftValue * leftValue;

            var rightValue = nums[right];
            var rightSquare = rightValue * rightValue;

            int value;
            if (leftSquare >= rightSquare)
            {
                value = leftSquare;
                left++;
            }
            else
            {
                value = rightSquare;
                right--;
            }

            result[currentIndex--] = value;
        }

        return result;
    }
}
