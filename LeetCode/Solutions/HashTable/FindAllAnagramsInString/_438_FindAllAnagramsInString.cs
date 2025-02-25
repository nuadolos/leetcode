namespace LeetCode.Solutions.HashTable.FindAllAnagramsInString;

public static class _438_FindAllAnagramsInString
{
    public static IList<int> Solution(string s, string p)
    {
        if (s.Length < p.Length)
            return [];

        var sCounter = new int[26];
        var pCounter = new int[26];

        for (int i = 0; i < p.Length; i++)
        {
            sCounter[s[i] - 'a']++;
            pCounter[p[i] - 'a']++;
        }

        var result = new List<int>();
        for (int i = 0; i < s.Length - p.Length; i++)
        {
            if (IsAnagram(sCounter, pCounter))
                result.Add(i);

            sCounter[s[i] - 'a']--;
            sCounter[s[i + p.Length] - 'a']++;
        }

        if (IsAnagram(sCounter, pCounter))
            result.Add(s.Length - p.Length);

        return result;
    }

    private static bool IsAnagram(int[] sCounter, int[] pCounter)
    {
        for (int i = 0; i < sCounter.Length; i++)
        {
            if (sCounter[i] != pCounter[i])
                return false;
        }

        return true;
    }
}

public static class _438_FindAllAnagramsInStringTestCases
{
    public static (string S, string P) Test_1 { get; } = ("cbaebabacd", "abc");
    public static (string S, string P) Test_2 { get; } = ("abab", "ab");
}