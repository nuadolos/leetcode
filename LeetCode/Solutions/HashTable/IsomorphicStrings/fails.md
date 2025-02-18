## Fails

1. Ошибка в алгоритме - ориентировался только на строку `s`, забыв что нужно хранить маппинг и для строки `t`.

```csharp
public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        var dictionary = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (dictionary.TryGetValue(s[i], out char tChar) && t[i] != tChar)
                return false;

            dictionary[s[i]] = t[i];
        }

        return true;
    }
}
```