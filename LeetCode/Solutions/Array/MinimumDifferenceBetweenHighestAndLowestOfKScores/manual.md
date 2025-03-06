## Success

```csharp
public class Solution
{
    public int MinimumDifference(int[] nums, int k)
    {
        if (k == 1)
            return 0;

        Array.Sort(nums);

        var minDifference = nums[^1];
        for (int i = 0; i <= nums.Length - k; i++)
        {
            var difference = nums[i + k - 1] - nums[i];
            if (minDifference > difference)
                minDifference = difference;
        }

        return minDifference;
    }
}
```

***Оценка по времени:*** O(n log n)

***Оценка по памяти:*** O(1)

**Описание решения**

Изначально сортируем массив, чтобы сократить в подмассивах, размером `k`, расстояние между значениями. Далее в каждом таком подмассиве берем мин. (`num[i]`) и макс. (`num[i + k - 1]`) значения, подсчитав разницу между ними. Результатом будет как раз минимальная разница в каком-то из подмассивов.