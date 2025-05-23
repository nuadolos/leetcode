## Success

```csharp
public class Solution
{
    public string MinRemoveToMakeValid(string s)
    {
        var resultIndex = 0;
        var result = new StringBuilder();
        var stack = new Stack<int>();
        
        for (int i = 0; i < s.Length; i++)
        {
            var ch = s[i];
            if (ch is ')' && !stack.TryPop(out var _))
                continue;
            else if (ch is '(')
                stack.Push(resultIndex);
            
            result.Append(ch);
            resultIndex++;
        }

        while (stack.TryPop(out var index))
            result.Remove(index, 1);
        
        return result.ToString();
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(n)

**Описание решения**

Создаем для очищенной строки от скобок новую строку через `StringBuilder`. Проходимся по всей строке в зависимости от текущего символа:
- добавляем закрывающую скобку, если данный символ это и есть та скобка, а также если удается взять из стека последнюю *открывающую скобку*, иначе - игнорируем.
- добавляем открывающую скобку всегда, но также добавляем текущий индекс открывающей скобки в стек.
- добавляем просто другие символы в результат.

Таким образом, после прохода строки, вопрос с закрывающими скобками будет решен. Теперь остается посмотреть, есть ли в стеке индексы открывающих скобок, которые говорят о том, что они являются лишними, так как не нашли пару. Создаем цикл, в котором убираем лишние открывающие скобки по индексу и очищаем стек. Далее отдаем результат.