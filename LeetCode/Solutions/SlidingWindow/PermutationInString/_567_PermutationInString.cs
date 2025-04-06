namespace LeetCode.Solutions.SlidingWindow.PermutationInString;

public static class _567_PermutationInString
{
    public static bool Solution(string s1, string s2)
    {
        if (s2.Length < s1.Length)
            return false;

        var s1Counter = new int[26];
        foreach (var c in s1)
            s1Counter[c - 'a']++;

        var s2Counter = new int[26];
        int l = 0, r = -1;
        while (l < s2.Length)
        {
            while (r + 1 < s2.Length)
            {
                var cIndex = s2[r + 1] - 'a';
                if (s2Counter[cIndex] + 1 > s1Counter[cIndex])
                    break;

                s2Counter[s2[++r] - 'a']++;
            }

            if (r - l + 1 == s1.Length)
                return true;

            s2Counter[s2[l++] - 'a']--;
        }

        return false;
    }
}

public static class _567_PermutationInStringTestCases
{
    public static (string S1, string S2) Test_1 { get; } = ("ab", "eidbaooo");
    public static (string S1, string S2) Test_2 { get; } = ("ab", "eidboaoo");
}