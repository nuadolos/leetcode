## Success

### Вариант 1

```csharp
public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var counter = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            counter.TryGetValue(nums[i], out var count);
            counter[nums[i]] = count + 1;
        }

        var frequency = new List<int>[nums.Length];
        foreach (var (key, value) in counter)
        {
            frequency[value - 1] ??= [];
            frequency[value - 1].Add(key);
        }

        var result = new int[k];
        var resultIndex = 0;

        for (int i = frequency.Length - 1; i >= 0; i--)
        {
            if (resultIndex == k)
                break;

            var list = frequency[i];
            if (list == null)
                continue;

            foreach (var num in list)
                result[resultIndex++] = num;
        }

        return result;
    }
}
```

***Оценка по времени:*** O(n)

Заполнение `counter` (n), заполнение `frequency` (n) и заполнение `result` (n): O(3n) => O(n)

***Оценка по памяти:*** O(n)

Точно также, как и ***оценка по времени***.

**Описание решения**

Изначально считаем кол-во одинаковых цифр с помощью счетчика. Далее меняем местами счетчик и ключ. Также у цифр может быть одинаковый счетчик, поэтому в массиве есть динамический список. В конце заполняем результат, начиная с конца массива `frequency`, чтобы получить наиболее встречаемые числа.

### Вариант 2 (оптимальное решение)

```csharp
public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        int min = nums[0], max = nums[0];

        foreach (int num in nums)
        {
            if (min > num)
                min = num;
            else if (max < num)
                max = num;
        }

        var counter = new int[max - min + 1];
        foreach (int num in nums)
            counter[num - min]++;

        var result = new int[k];
        for (int i = 0; i < k; i++)
        {
            int maxCount = -1, maxIndex = -1;

            for (int j = 0; j < counter.Length; j++)
            {
                var count = counter[j];
                if (maxCount < count)
                    (maxCount, maxIndex) = (count, j);
            }

            result[i] = maxIndex + min;
            counter[maxIndex] = -1;
        }

        return result;
    }
}
```

***Оценка по времени:*** O(n + kR)

Нахождение `min` и `max` (n), заполнение счетчика (n) и заполнение результатом посредством перебора счетчика с нахождением максимального (k * R, где R - диапозон значений в массиве `nums`): O(2n + kR) => O(n + kR)

***Оценка по памяти:*** O(R + k)

В данном же случае заполняем счетчик (R - диапозон значений в массиве `nums`) и заполнение результата (k): O(R + k) 

**Описание решения**

Минуем массив `frequency`, а просто каждый раз ищем максимальный счетчик в массиве `counter`. Также заменена хеш-таблица на **Count sort**, что работает немного быстрее.