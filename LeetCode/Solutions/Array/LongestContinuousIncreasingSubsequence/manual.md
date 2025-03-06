## Success

```csharp
public class Solution
{
    public int FindLengthOfLCIS(int[] nums)
    {
        int count = 1, maxCount = 1;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i + 1] > nums[i])
            {
                count++;
                if (maxCount < count)
                    maxCount = count;
            }
            else
                count = 1;
        }

        return maxCount;
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(1)

**Описание решения**

Ведем два счетчика: текущий и максимальный, равный изначально 1 (подмассив не может быть меньше 1). Далее проверяем последовательность, обновляя счетчики. Если же последовательность прекращается, то обновляем текущий счетчик. Результатом является переменная `maxCount`.