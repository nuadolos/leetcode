## Success

```csharp
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dictionary = new Dictionary<int, int>();

        for (int firstIndex = 0; firstIndex < nums.Length; firstIndex++)
        {
            var num = nums[firstIndex];
            if (dictionary.TryGetValue(target - num, out var secondIndex))
                return [firstIndex, secondIndex];

            dictionary[num] = firstIndex;
        }

        throw new NotSupportedException();
    }
}
```

***Оценка по времени:*** O(n)

Худший вариант - два последних элемента являются ответом.

***Оценка по памяти:*** O(n)

Худший вариант - два последних элемента являются ответом, так как тогда хеш-таблица будет содержать n-1 кол-во элементов.

**Описание решения**

Инициализируем хеш-таблицу, в которой будет находится число из массива (key) и ее индекс в этом массиве (value). Далее проход по массиву с условием, есть ли в хеш-таблице число, необходимое для суммы с `num`, чтобы получить `target`. Если такого числа нет, то в хеш-таблицу запишется `num` со своим индексом в массиве. Результатом функции будет два индекса, один из которых будет получен из хеш-таблицы.