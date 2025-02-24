namespace LeetCode.Solutions.HashTable.ValidAnagram;

public static class _242_ValidAnagram
{
    public static bool Solution(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var counter = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            counter[s[i] - 'a']++;
            counter[t[i] - 'a']--;
        }

        foreach (int count in counter)
        {
            if (count != 0)
                return false;
        }

        return true;
    }
}

public static class _242_ValidAnagramTestCases
{
    public static (string S, string T) Test_1 { get; } = ("anagram", "nagaram");
    public static (string S, string T) Test_2 { get; } = ("rat", "car");
}