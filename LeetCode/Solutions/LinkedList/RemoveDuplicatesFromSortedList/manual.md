## Success

```csharp
public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        ListNode? prev = head, current = head?.next;
        while (current != null)
        {
            if (prev!.val == current.val)
                prev.next = current.next;
            else
                prev = current;

            current = current.next;
        }

        return head;
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(1)

**Описание решения**

Создаем два указателя на предыдущий и текущий узлы. Изначально скипаем один узел, так как он всегда будет уникальным. Итерируемся, пока `current` не будет указывать на пустой узел. Если значения `prev` и `current` совпадают, то `prev.next` теперь будет указывать на `current.next`, при этом `prev` не смещаем, так как следующий узел также может быть дублем. Смещаем `prev` только тогда, когда значения не равны, что означает больше дублей с таким значением нет. И каждую итерацию передвигаем `current` на следующий узел.