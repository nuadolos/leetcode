using LeetCode.Structures;

namespace LeetCode.Solutions.BinaryTree.ConvertSortedArrayToBinarySearchTree;

public static class _108_ConvertSortedArrayToBinarySearchTree
{
    public static TreeNode Solution(int[] nums)
    {
        return CreateTreeNodeFromSortedArray(nums, 0, nums.Length - 1)!;
    }
    
    private static TreeNode? CreateTreeNodeFromSortedArray(int[] nums, int left, int right)
    {
        if (left > right)
            return null;

        var mid = (left + right) / 2;

        return new TreeNode
        {
            val = nums[mid],
            left = CreateTreeNodeFromSortedArray(nums, left, mid - 1),
            right = CreateTreeNodeFromSortedArray(nums, mid + 1, right)
        };
    }
}

public static class _108_ConvertSortedArrayToBinarySearchTreeTestCases
{
    public static int[] Test_1 { get; } = [-10, -3, 0, 5, 9];
}