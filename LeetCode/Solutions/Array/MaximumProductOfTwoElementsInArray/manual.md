## Success

```csharp
public class Solution
{
    public int MaxProduct(int[] nums)
    {
        int max1 = 0, max2 = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (num > max1)
                (max1, max2) = (num, max1);
            else if (num > max2)
                max2 = num;
        }

        return (max1 - 1) * (max2 - 1);
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(1)

**Описание решения**

Ищем два максимальных числа и затем отнимаем по единице. Произведение этих двух чисел и будет ответом.