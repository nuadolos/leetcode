## Success

```csharp
public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 0, right = numbers.Length - 1;
        while (left < right)
        {
            var sum = numbers[left] + numbers[right];
            if (sum == target)
                return [left + 1, right + 1];
            else if (sum > target)
                right--;
            else
                left++;    
        }
        
        return [];
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(1)

**Описание решения**

Используем два указателя с двух сторон, так как массив *отсортирован по возрастанию*. На каждом шаге считаем сумму двух элементов и сравниваем с `target`. Если равны, то мы нашли два индекса. Если же сумма больше `target`, значит нужно уменьшать `right`, чтобы второй элемент был меньше предыдущего. Если же сумма меньше `target`, значит нужно увеличить `left`, чтобы первый элемент был больше предыдущего.