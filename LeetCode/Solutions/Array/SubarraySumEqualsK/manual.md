## Success

```csharp
public class Solution
{
    public int SubarraySum(int[] nums, int k)
    {
        int sum = 0, subarrayCount = 0;
        var prefixSumCounter = new Dictionary<int, int>
        {
            [0] = 1
        };

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            if (prefixSumCounter.TryGetValue(sum - k, out var prefixSumCount))
                subarrayCount += prefixSumCount;
            
            prefixSumCounter.TryGetValue(sum, out var sumCount);
            prefixSumCounter[sum] = sumCount + 1; 
        }
        
        return subarrayCount;
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(n)

**Описание решения**

Инициализируем глобальную сумму и счетчик подмассивов, а также хеш-таблицу для подсчета уже встречаемых нам сумм. Изначально в хеш-таблицу записываем `[0] = 1`, чтобы при встречи суммы, равной `k`, записать кол-во таких подмассивов в глобальный счетчик. Далее же проходимся по всему массиву, проверяя что есть ли префиксная сумма, равную `sum - k`. Если такая сумма была найдена, значит существует подмассив, который заканчивается в `i` и сумма которого равна `k`, и добавляем количество таких подмассивов в `subarrayCount`. Далее на каждом шаге записываем текущую сумму в хеш-таблицу, увеличивая счетчик найденных таким сумм, которые учитываются для будущих подмассивов.