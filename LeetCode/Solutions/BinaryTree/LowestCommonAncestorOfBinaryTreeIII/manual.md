## Success

### Пометка

LCA (Lowest Common Ancestor) двух узлов — это узел, который является их общим предком и находится на минимальной возможной глубине.

- Если один узел является предком другого, то LCA — это сам этот узел.
- Если узлы находятся в разных поддеревьях, LCA — это первый узел выше по дереву, имеющий их обоих в своих поддеревьях.

### Вариант 1 (написанный мной)
 
```csharp
public class Solution
{
    public Node LowestCommonAncestor(Node p, Node q)
    {
        var dictionary = new Dictionary<int, Node>();

        var lastPNode = p;
        while (lastPNode != null)
        {
            dictionary.Add(lastPNode.val, lastPNode);
            lastPNode = lastPNode.parent;
        }

        var lastQNode = q;
        while (lastQNode != null)
        {
            if (dictionary.ContainsKey(lastQNode.val))
                break;

            lastQNode = lastQNode.parent;
        }

        return lastQNode!;
    }
}
```

***Оценка по времени:*** O(h)

Худший вариант - дерево "бамбук", тогда O(h) = O(n).

***Оценка по памяти:*** O(h)

Так как используем хеш-таблицу. Поиск по ней занимает O(1), но может храниться и весь список вершин (если это дерево "бамбук").

**Описание решения**

Сначала делаем проход по первой вершине до ее родителя, записывая в хеш-таблицу значение вершины. Затем делаем проход по второй вершине до ее совместного с первым родителя, проверяя в хеш-таблице значения каждой вершины.

### Вариант 2 (оптимальное решение)

```csharp
public class Solution
{
    public Node LowestCommonAncestor(Node p, Node q)
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
```

***Оценка по времени:*** O(h)

Худший вариант - дерево "бамбук", тогда O(h) = O(n).

***Оценка по памяти:*** O(1)

Нет ни рекурсии, ни хеш-таблиц.

**Описание решения**

Сначала делаем вычисляем глубину для каждой вершины при помощи родителей. Далее задаем условие, чтобы `p` всегда был больше по глубине, чем `q`. Затем выстраиваем им одну глубину, то есть для `p` уменьшаем глубину, возвращая родителя на том же уровне, что и `q`. Далее двигаемся по родителям с одной глубины, уменьшая с каждой итерацией глубину, таким образом результатом будет первый общий родитель.