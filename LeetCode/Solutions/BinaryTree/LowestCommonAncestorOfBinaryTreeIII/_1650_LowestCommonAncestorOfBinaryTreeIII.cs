using LeetCode.Structures;

namespace LeetCode.Solutions.BinaryTree.LowestCommonAncestorOfBinaryTreeIII;

public static class _1650_LowestCommonAncestorOfBinaryTreeIII
{
    public static Node Solution(Node p, Node q)
    {
        var pDepth = Depth(p);
        var qDepth = Depth(q);

        if (qDepth > pDepth)
        {
            (p, q) = (q, p);
            (pDepth, qDepth) = (qDepth, pDepth);
        }

        for (var i = qDepth; i < pDepth; i++)
            p = p.parent!;

        while (p != q)
        {
            p = p.parent!;
            q = q.parent!;
        }

        return p!;
    }

    private static int Depth(Node node)
    {
        var depth = 0;

        while (node != null)
        {
            depth++;
            node = node.parent!;
        }

        return depth;
    }
}

public static class _1650_LowestCommonAncestorOfBinaryTreeIIITestCases
{
    public static (Node P, Node Q) Test_1 { get; }
    public static (Node P, Node Q) Test_2 { get; }

    static _1650_LowestCommonAncestorOfBinaryTreeIIITestCases()
    {
        var node3 = new Node(3);
        var node5 = new Node(5, parent: node3);
        Test_1 = (node5, new Node(1, parent: node3));

        var node2 = new Node(2, parent: node5);
        Test_2 = (node5, new Node(4, parent: node2));
    }
}