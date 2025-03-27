namespace LeetCode.Solutions.SlidingWindow.LongestSubstringWithoutRepeatingCharacters;

public static class _3_LongestSubstringWithoutRepeatingCharacters
{
    public static int Solution(string s)
    {
        if (s.Length < 2)
            return s.Length;

        var hashSet = new HashSet<char>();
        int l = 0, r = -1, maxLength = 0;
        while (l < s.Length)
        {
            while (r + 1 < s.Length && !hashSet.Contains(s[r + 1]))
                hashSet.Add(s[++r]);

            var length = r - l + 1;
            if (maxLength < length)
                maxLength = length;

            hashSet.Remove(s[l++]);
        }

        return maxLength;
    }
}

public static class _3_LongestSubstringWithoutRepeatingCharactersTestCases
{
    public static string Test_1 { get; } = "abcabcbb";
    public static string Test_2 { get; } = "bbbbb";
}