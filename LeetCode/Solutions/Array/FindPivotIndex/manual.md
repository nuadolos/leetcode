## Success

```csharp
public class Solution
{
    public int PivotIndex(int[] nums)
    {
        var sumRight = 0;
        for (int i = 0; i < nums.Length; i++)
            sumRight += nums[i];

        var sumLeft = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sumRight -= nums[i];

            if (sumLeft == sumRight)
                return i;

            sumLeft += nums[i];
        }

        return -1;
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(1)

**Описание решения**

Находим изначально сумму всех элементов, далее начинаем приводить суммы к равенству. Если же суммы ни разу не будут равны друг другу, тогда индекс поворота отсутствует в массиве.