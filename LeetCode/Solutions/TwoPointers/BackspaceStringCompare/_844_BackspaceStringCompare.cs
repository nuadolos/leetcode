namespace LeetCode.Solutions.TwoPointers.BackspaceStringCompare;

public static class _844_BackspaceStringCompare
{
    public static bool Solution(string s, string t)
    {
        int sIndex = s.Length, tIndex = t.Length;
        while (sIndex > -1 && tIndex > -1)
        {
            sIndex = FindIndexAfterSkippingBackspaces(s, sIndex - 1);
            tIndex = FindIndexAfterSkippingBackspaces(t, tIndex - 1);

            if (sIndex >= 0 && tIndex >= 0 && s[sIndex] != t[tIndex])
                return false;
        }

        return sIndex == tIndex;
    }

    private static int FindIndexAfterSkippingBackspaces(string s, int currentIndex)
    {
        var skipCouint = 0;
        while (currentIndex >= 0)
        {
            var isSharp = s[currentIndex] == '#';
            if (skipCouint == 0 && !isSharp)
                break;

            if (s[currentIndex] == '#')
                skipCouint++;
            else
                skipCouint--;

            currentIndex--;
        }

        return currentIndex;
    }
}

public static class _844_BackspaceStringCompareTestCases
{
    public static (string S, string T) Test_1 { get; } = ("a#c", "b");
    public static (string S, string T) Test_2 { get; } = ("bxj##tw", "bxj###tw");
}