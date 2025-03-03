## Success

```csharp
public class Solution
{
    public bool IsMonotonic(int[] nums)
    {
        if (nums.Length <= 2)
            return true;

        var prevNum = nums[0];

        bool? isIncreasing = null;
        for (int i = 1; i < nums.Length; i++)
        {
            var num = nums[i];

            if (prevNum < num)
            {
                if (isIncreasing == false)
                    return false;

                isIncreasing ??= true;
            }
            else if (prevNum > num)
            {
                if (isIncreasing == true)
                    return false;

                isIncreasing ??= false;
            }

            prevNum = num;
        }

        return true;
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(1)

**Описание решения**

Проверяем, что если первый элемент меньше, чем второй, то это возрастающий массив, иначе убывающий. Далее, зная что это за массив, проходимся по всем элементам, проверяя то же самое условие. Если массив нарушает изначальное свойство массива, то массив не является монотомным.