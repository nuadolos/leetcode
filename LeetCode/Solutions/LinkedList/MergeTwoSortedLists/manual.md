## Success

```csharp
public class Solution
{
    public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        var dummy = new ListNode();
        var current = dummy;

        while (list1 != null || list2 != null)
        {
            if (list1 != null && (list2 == null || list1.val < list2.val))
            {
                current!.next = list1;
                list1 = list1.next;
            }
            else
            {
                current!.next = list2;
                list2 = list2!.next;
            }

            current = current.next;
        }

        return dummy.next;
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(1)

**Описание решения**

Создаем фейковый узел, который нужен для того, чтобы не думать, кто будет первым `list1` или `list2`. Далее передвигаемся по спискам двумя указателями, так как данные списки уже отсортированы по возрастанию. Далее сравниваем значение `val` у узлов или проверяем, кто из узлов `null`. В зависимости от проверки выставляем для текущего узла следующий узел (`list1` или `list2`) и передвигаем указатель на следующий узел. Также поступаем и с `current`, передвигая его на следующий ранее записанный узел. В конце отдаем `dummy.next`, так как это фейковый узел, а следующий узел уже как раз начало `list1` или `list2`. 