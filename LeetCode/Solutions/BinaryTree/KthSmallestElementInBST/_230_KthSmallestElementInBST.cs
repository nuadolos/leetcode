using LeetCode.Structures;

namespace LeetCode.Solutions.BinaryTree.KthSmallestElementInBST;

public static class _230_KthSmallestElementInBST
{
    public static int Solution(TreeNode root, int k)
    {
        return FindKthSmallestNode(root, ref k)!.val;
    }

    private static TreeNode? FindKthSmallestNode(TreeNode? node, ref int k)
    {
        if (node == null)
            return null;

        if (FindKthSmallestNode(node.left, ref k) is { } result)
            return result;

        k--;
        if (k == 0)
            return node;

        return FindKthSmallestNode(node.right, ref k);
    }
}

public static class _230_KthSmallestElementInBSTTestCases
{
    public static (TreeNode, int) Test_1 { get; } =
    (
        new TreeNode
        {
            val = 3,
            left = new TreeNode(1, right: new TreeNode(2)),
            right = new TreeNode(4)
        },
        1
    );

    public static (TreeNode, int) Test_2 { get; } =
    (
        new TreeNode
        {
            val = 5,
            left = new TreeNode(
                val: 3, 
                left: new TreeNode(2, left: new TreeNode(1)),
                right: new TreeNode(4)),
            right = new TreeNode(6)
        },
        3
    );
}
