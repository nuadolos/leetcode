namespace LeetCode.Solutions.TwoPointers.ContainerWithMostWater;

public static class _11_ContainerWithMostWater
{
    public static int Solution(int[] height)
    {
        int left = 0, right = height.Length - 1, maxArea = 0, maxHeight = 0;
        while (left < right)
        {
            var leftHeight = height[left];
            if (leftHeight <= maxHeight)
            {
                left++;
                continue;
            }

            var rightHeight = height[right];
            if (rightHeight <= maxHeight)
            {
                right--;
                continue;
            }

            maxHeight = leftHeight < rightHeight
                ? leftHeight
                : rightHeight;

            var area = maxHeight * (right - left);
            if (maxArea < area)
                maxArea = area;
        }

        return maxArea;
    }
}

public static class _11_ContainerWithMostWaterTestCases
{
    public static int[] Test_1 { get; } = [1, 8, 6, 2, 5, 4, 8, 3, 7];
    public static int[] Test_2 { get; } = [4, 5];
}