using LeetCode.Structures;

namespace LeetCode.Solutions.BinaryTree.ValidateBinarySearchTree;

public static class _98_ValidateBinarySearchTree
{
    public static bool Solution(TreeNode root)
    {
        return IsValidBST(root, long.MinValue, long.MaxValue);
    }

    private static bool IsValidBST(TreeNode? node, long minValue, long maxValue)
    {
        if (node == null)
            return true;

        if (node.val <= minValue || node.val >= maxValue)
            return false;

        return IsValidBST(node.left, minValue, node.val)
            && IsValidBST(node.right, node.val, maxValue);
    }
}

public static class _98_ValidateBinarySearchTreeTestCases
{
    public static TreeNode Test_1 { get; } = new TreeNode
    {
        val = 2,
        left = new TreeNode
        {
            val = 1
        },
        right = new TreeNode
        {
            val = 3,
        }
    };

    public static TreeNode Test_2 { get; } = new TreeNode
    {
        val = 5,
        left = new TreeNode
        {
            val = 1
        },
        right = new TreeNode
        {
            val = 4,
            left = new TreeNode
            {
                val = 3,
            },
            right = new TreeNode
            {
                val = 5,
            }
        }
    };

    public static TreeNode Test_3 { get; } = new TreeNode
    {
        val = 2147483647,
    };
}
