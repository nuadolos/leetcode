## Success

```csharp
public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();
        
        foreach (var token in tokens)
        {
            if (int.TryParse(token, out var num))
            {
                stack.Push(num);
                continue;
            }
            
            var secondOperand = stack.Pop();
            var firstOperand = stack.Pop();
            
            var operationResult = token switch
            {
                "+" => firstOperand + secondOperand,
                "-" => firstOperand - secondOperand,
                "*" => firstOperand * secondOperand,
                _ => firstOperand / secondOperand
            };
            
            stack.Push(operationResult);
        }
        
        return stack.Pop();
    }
}
```

***Оценка по времени:*** O(n)

***Оценка по памяти:*** O(n)

**Описание решения**

Проходимся по массиву токенов. Если это число, то помещаем просто число в стек. Иначе это оператор, в котором участвуют два операнда, согласно [обратной польской записи](https://en.wikipedia.org/wiki/Reverse_Polish_notation), поэтому первый из стека это второй операнд, следующий - первый операнд. Совершаем операцию и записываем ее результат в стек. Таким образом, к концу цикла в стеке будет один элемент, который и будет результатом всех совершенных операций.