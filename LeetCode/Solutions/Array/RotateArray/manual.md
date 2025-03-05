## Success

```csharp
public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        k %= nums.Length;
        ReverseArray(nums, 0, nums.Length - 1);
        ReverseArray(nums, 0, k - 1);
        ReverseArray(nums, k, nums.Length - 1);
    }

    private static void ReverseArray(int[] nums, int start, int end)
    {
        for (int i = start, j = end; i < j; i++, j--)
            (nums[i], nums[j]) = (nums[j], nums[i]);
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(1)

**Описание решения**

Если `k` больше длины массива, сдвиг `k` эквивалентен `k % n`, так как массив после `n` полных вращений возвращается в исходное состояние. Далее переворачиваем полностью массив, потом массив от `0` до `k - 1` и массив от `k` до `n - 1`. Тем самым за 3 операции получаем правильный результат.