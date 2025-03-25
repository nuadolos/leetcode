## Success

### Вариант 1

```csharp
public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        var result = new List<string>();
        if (nums.Length == 0)
            return result;

        int beginNum = nums[0], endNum = beginNum;
        for (int i = 1; i < nums.Length; i++)
        {
            var curr = nums[i];

            if (endNum + 1 != curr)
            {
                result.Add(beginNum == endNum
                    ? beginNum.ToString()
                    : beginNum.ToString() + "->" + endNum.ToString());
                beginNum = curr;
            }

            endNum = curr;
        }

        result.Add(beginNum == endNum
            ? beginNum.ToString()
            : beginNum.ToString() + "->" + endNum.ToString());
        
        return result;
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(n)

**Описание решения**

Запоминаем начальную цифру для указателей `beginNum` и `endNum`. Далее двигаемся по массиву, сравнивая `endNum + 1` с текущим элементом. Если они не равны, значит диапазон закончился, иначе двигаемся дальше, пока не встретим окончание диапазона. Далее в результат записывается диапазон или цифра в зависимости, равен ли `beginNum` переменной `endNum`. Так как итерируемся относительно правого указателя, то последний результат может быть пропущен в итерации, поэтому окончательно его записываем после выхода из цикла.

### Вариант 2 (применяется паттерн)

```csharp
public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        var result = new List<string>();
        if (nums.Length == 0)
            return result;
        
        int left = 0, right = 0;
        while (left < nums.Length)
        {
            while (right + 1 < nums.Length && nums[right] + 1 == nums[right + 1])
                right++;
                
            result.Add(left == right
                ? nums[left].ToString()
                : nums[left].ToString() + "->" + nums[right].ToString());
                
            left = right = right + 1;        
        }
        
        return result;
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(n)

**Описание решения**

Такое же решение, но итерируемся относительно от левого указателя. Правый указатель высчитываем циклом, пока не встретится число, которое не равно *следующему - 1*.