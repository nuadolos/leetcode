## Success

```csharp
public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        var result = new List<string>();
        var sb = new StringBuilder();
        Backtrack(0, 0);
        return result;
        
        void Backtrack(int open, int close)
        {
            if (n * 2 == sb.Length)
            {
                result.Add(sb.ToString());
                return;
            }
            
            if (open < n)
            {
                sb.Append('(');
                Backtrack(open + 1, close);
                sb.Length--;
            }
            
            if (close < open)
            {
                sb.Append(')');
                Backtrack(open, close + 1);
                sb.Length--;
            }
        }
    }
}
```

***Оценка по времени:*** O(2^n) или O(Cn)

***Оценка по памяти:*** O(2^n) или O(Cn)

Где Cn - n-ое [число Каталана](http://e-maxx.ru/algo/catalan_numbers).

**Описание решения**

Заходим в метод `Backtrack` с нулевых позиций. Переменная `open` отвечает за кол-во открытых скобок, а `close` - кол-во закрытых. Результатом для нас будет `n * 2`, так как `n` - кол-во пар скобок. Условие `open < n` проверяет, можно ли вставить еще одну открытую скобку. Если `open` больше `n`, значит кол-во открытых скобок будет больше, чем закрытых, и пары не получатся. Условие `close < open` проверяет, можно ли вставить еще одну открытую скобку. Если `close` окажется больше `open`, значит отсутствуют открытые скобки для создания пары.