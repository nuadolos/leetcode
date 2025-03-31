## Success

```csharp
public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        if (nums.Length == 1)
            return nums[0];
            
        int l = 0, r = -1;
        double sum = 0, maxAverage = double.MinValue;
        while (l + k <= nums.Length)
        {
            while (r + 1 < nums.Length && r + 1 < l + k)
                sum += nums[++r];
                
            var average = sum / k;
            if (maxAverage < average)
                maxAverage = average;
                
            sum -= nums[l++];    
        }
        
        return maxAverage;
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(1)

**Описание решения**

Итерируемся по массиву относительно левого указателя. Увеличиваем правый указатель и считаем сумму до тех пор, пока не упремся в `l + k`. Далее подсчитываем среднюю сумму k-элементов, сравнивая ее с ранее встречаемым максимальным значением. И убираем значение левого указателя из суммы, смещая указатель на единицу.