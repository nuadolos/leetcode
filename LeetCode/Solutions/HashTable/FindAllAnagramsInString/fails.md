## Fails

Без ошибок :)

Но есть нюанс - первое решение по времени составило `294 мс`.

```csharp
public class Solution {
    public IList<int> FindAnagrams(string s, string p)
    {
        var map = new Dictionary<string, IList<int>>();

        for (int i = 0; i <= s.Length - p.Length; i++)
        {
            var key = GetHashAnagramKey(s, p, i);
            if (map.TryGetValue(key, out var list))
                list.Add(i);
            else
                map[key] = [i];
        }

        var pKey = GetHashAnagramKey(p, p, 0);
        return map.TryGetValue(pKey, out var result)
            ? result
            : [];
    }

    private static string GetHashAnagramKey(string s, string p, int index)
    {
        var counter = new char[26];

        for (int j = 0; j < p.Length; j++)
            counter[s[j + index] - 'a']++;

        return new string(counter);
    }
}
```