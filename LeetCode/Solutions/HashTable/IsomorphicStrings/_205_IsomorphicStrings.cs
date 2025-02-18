namespace LeetCode.Solutions.HashTable.IsomorphicStrings;

public static class _205_IsomorphicStrings
{
    public static bool Solution(string s, string t)
    {
        var sMap = new Dictionary<char, int>();
        var tMap = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            var sChar = s[i];
            var tChar = t[i];

            if (!sMap.TryGetValue(sChar, out var sIndex))
            {
                sMap[sChar] = i;
                sIndex = i;
            }

            if (!tMap.TryGetValue(tChar, out var tIndex))
            {
                tMap[tChar] = i;
                tIndex = i;
            }

            if (sIndex != tIndex)
                return false;
        }

        return true;
    }
}

public static class _205_IsomorphicStringsTestCases
{
    public static (string S, string T) Test_1 { get; } = ("foo", "bar");
    public static (string S, string T) Test_2 { get; } = ("paper", "title");
}