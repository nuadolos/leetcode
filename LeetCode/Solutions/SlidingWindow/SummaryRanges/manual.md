## Success

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