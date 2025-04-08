## Success

```csharp
public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var dummy = new ListNode(0, head);
        
        var fast = dummy;
        for (int i = 0; i <= n; i++)
            fast = fast.next;
            
        var slow = dummy;
        while (fast != null)
        {
            slow = slow.next;
            fast = fast.next;
        }
                
        slow.next = slow.next.next;
        
        return dummy.next; 
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(1)

**Описание решения**

Изначально создаем фейковый узел, чтобы в случае удаления первого узла операция была идентична, как над другими узлами. Чтобы найти узел, который нужно удалить, мы используем два указателя, передвигая сразу быстрый на `n + 1` узел. Тем самым `slow` окажется на нужном узле, когда `fast` окажется на пустом узле. Так как `slow` стоит перед узлом, который нужно удалить, мы просто заменяем следующий узел на следующий узел удаляемого узла. В ответе отдаем `dummy.next`, так как первый - это фейковый узел, а следующий узел уже является `head`.