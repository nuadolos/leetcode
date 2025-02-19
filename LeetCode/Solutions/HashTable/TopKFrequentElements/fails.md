## Fails

1. Ошибка в алгоритме - использовал в массиве `frequency` тип `int?[]` вместо `List<int>[]`, хотя счетчик для цифр может быть одинаковым.

```csharp
public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var counter = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            counter.TryAdd(nums[i], 0);
            counter[nums[i]]++;
        }

        var frequency = new int?[nums.Length]; // тут перекрывались значения с тем же счетчиком
        foreach (var (key, value) in counter)
            frequency[value - 1] = key;

        var result = new int[k];
        var resultIndex = k;

        for (int i = frequency.Length - 1; i >= 0; i--)
        {
            if (resultIndex == 0)
                break;

            var num = frequency[i];
            if (num == null)
                continue;

            resultIndex--;
            result[resultIndex] = num.Value;
        }

        return result;
    }
}
```

2. Ошибка во время выполнения (3 раза встретилась) - постоянно выходил за границы массива, а также ошибка в конструкциях `counter[nums[i]]++` (так как `counter[nums[i]]` ранее не был задан, то выбрасывается исключение `KeyNotFoundException`) и `frequency[value - 1].Add(key)` (тут была проблема, что ранее не инициализировал список, там был `null`).