## Success

```csharp
public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        var slow = head;
        var fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow!.next;
            fast = fast.next.next;
        }

        return slow!;
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(1)

**Описание решения**

Используем паттерн "Медленный и быстрый указатели". Изначально два указателя указывают на один и тот же узел. Проверяем, что у быстрый указатель `not null` и его следующий элемент также `not null`. И если условие проходит, то смещаем `slow` на один узел, а `fast` - уже на два узла. Медленный указатель и будет серединой связанного списка.