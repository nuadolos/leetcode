## Success

```csharp
public class Solution
{
    public int MissingNumber(int[] nums)
    {
        var n = nums.Length;
        var sum = n * (n + 1) / 2;
        
        for (int i = 0; i < n; i++)
            sum -= nums[i];
            
        return sum;        
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(1)

**Описание решения**

Считаем изначально сумму всех элементов от 0 до `n` с помощью формулы. Далее проходимся по массиву, отнимая каждый элемент массива от подсчитанной суммы всех элементов. В итоге получаем число, которого не хватает в массиве.