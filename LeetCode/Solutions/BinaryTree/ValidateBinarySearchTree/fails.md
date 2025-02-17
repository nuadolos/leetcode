## Fails

1. Ошибка в результате **(тест-кейс 78 root=[2147483647])** из-за недосмотра ограничений по значения вершины, то есть `int.MinValue` и `int.MaxValue` могли быть значением вершины.

```csharp
public class Solution {
    public bool IsValidBST(TreeNode root) {
        return IsValidBST(root, int.MinValue, int.MaxValue);
    }

    private static bool IsValidBST(TreeNode? node, int minValue, int maxValue)
    {
        if (node == null)
            return true;

        if (node.val <= minValue || node.val >= maxValue)
            return false;

        return IsValidBST(node.left, minValue, node.val)
            && IsValidBST(node.right, node.val, maxValue);
    }
}
```