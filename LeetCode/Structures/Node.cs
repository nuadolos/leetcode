namespace LeetCode.Structures;

public record Node(int val = 0, Node? left = null, Node? right = null, Node? parent = null)
{
    public int val = val;
    public Node? left = left;
    public Node? right = right;
    public Node? parent = parent;
}
