## Success

```csharp
public class Solution
{
    public int KthSmallest(TreeNode root, int k)
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
```

***Оценка по времени:*** O(n)

Худший вариант - k является индексом самой правой нижней вершины.

***Оценка по памяти:*** O(h)

**Описание решения**

Делаем проход до самой левой нижней вершине, а далее, ведя счетчик (k уменьшается), идем в порядке возрастания, то есть обходим сначала все левые вершины, затем считаем вершину, на которой находимся, далее ее все правые. Ответ возвращаем обратно вверх к родителю.