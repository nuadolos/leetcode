namespace LeetCode.Solutions.TwoPointers.ValidPalindrome;

public static class _125_ValidPalindrome
{
    public static bool Solution(string s)
    {
        int left = 0, right = s.Length - 1;
        while (left < right)
        {
            if (!IsLetterOrDigit(s[left]))
                left++;
            else if (!IsLetterOrDigit(s[right]))
                right--;
            else if (ToLower(s[left++]) != ToLower(s[right--]))
                return false;
        }

        return true;
    }

    private static bool IsLetterOrDigit(char c) =>
        (c - 'a' is >= 0 and <= 25)
            || (c - 'A' is >= 0 and <= 25)
            || (c - '0' is >= 0 and <= 9);

    private static char ToLower(char c) =>
        c - 'A' is >= 0 and <= 25
            ? (char)('a' + (c - 'A'))
            : c;
}

public static class _125_ValidPalindromeTestCases
{
    public static string Test_1 { get; } = "A man, a plan, a canal: Panama";
    public static string Test_2 { get; } = "race a car";
}