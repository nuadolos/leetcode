## Success

### Вариант 1

```csharp
public class Solution
{
    public int MaxArea(int[] height)
    {
        int left = 0, right = height.Length - 1, maxArea = 0;
        while (left < right)
        {
            var leftHeight = height[left];
            var rightHeight = height[right];
            
            var area = Math.Min(leftHeight, rightHeight) * (right - left);
            if (maxArea < area)
                maxArea = area;
                
            if (leftHeight > rightHeight)
                right--;
            else
                left++;     
        }
        
        return maxArea;
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(1)

**Описание решения**

Используем два указателя с двух сторон, а также максимальную емкость, которую позже отдаем в ответ. Проходимся по массиву, высчитывая емкость по формуле. Сдвиг одного из указателей происходит посредством сравнения элементов. Если левый элемент больше правого, то уменьшаем правый указатель, иначе - левый.

### Вариант 2 (чуть оптимальнее)

```csharp
public class Solution
{
    public int MaxArea(int[] height)
    {
        int left = 0, right = height.Length - 1, maxArea = 0, maxHeight = 0;
        while (left < right)
        {
            var leftHeight = height[left];
            if (leftHeight <= maxHeight)
            {
                left++;
                continue;
            }

            var rightHeight = height[right];
            if (rightHeight <= maxHeight)
            {
                right--;
                continue;
            }

            maxHeight = leftHeight < rightHeight
                ? leftHeight
                : rightHeight;

            var area = maxHeight * (right - left);
            if (maxArea < area)
                maxArea = area;
        }

        return maxArea;
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(1)

**Описание решения**

Тоже самое решение, но добавляется переменная `maxHeight`, которая отвечает за двиг указателей, а также пропускает минимальные значения в массиве ближе к центру, так как они точно никогда не дадут максимальную емкость.