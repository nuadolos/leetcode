## Success

```csharp
public class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        ListNode? slow = head, fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow!.next;
            fast = fast.next.next;
        }

        ListNode? prev = null, current = slow;
        while (current != null)
        {
            var tmp = current;
            current = current.next;
            tmp.next = prev;
            prev = tmp;
        }

        ListNode? left = head, right = prev;
        while (right != null)
        {
            if (left!.val != right.val)
                return false;

            left = left.next;
            right = right.next;
        }

        return true;
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(1)

**Описание решения**

Изначально находим середину. Далее узлы, начиная с середины, разворачиваем. И имея левый (`head`) и правый (`prev`) указатели, сравниваем значения этих узлов до тех пор, пока правый указатель не будет пустым (при развороте мы позаботились, что `slow.next` будет `null`). Если бы в задаче требовалось вернуть `head` в исходное состояние, то было бы достаточно передать `prev` как точку начала для разворота.