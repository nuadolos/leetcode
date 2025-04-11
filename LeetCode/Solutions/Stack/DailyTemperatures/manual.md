## Success

```csharp
public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        var result = new int[temperatures.Length];
        var stack = new Stack<int>();

        for (int i = 0; i < temperatures.Length; i++)
        {
            while (stack.Count > 0
                && temperatures[stack.Peek()] < temperatures[i])
            {
                var lastTIndex = stack.Pop();
                result[lastTIndex] = i - lastTIndex;
            }
            
            stack.Push(i);
        }
            
        return result;    
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(n)

**Описание решения**

Проходимся по массиву температур. Проверяем наличие элементов в стеке, и если температура последнего индекса в стеке меньше, чем температура текущего индекса, то присваиваем результату количество дней (`i - lastTIndex`), через которые температура повысилась, а также убирай последний индекс из стека. В конце каждой итерации записываем текущий индекс в стек.