namespace LeetCode.Solutions.HashTable.PalindromePermutation;

public static class _266_PalindromePermutation
{
    public static bool Solution(string s)
    {
        var counter = new int[26];
        foreach (var letter in s)
            counter[letter - 'a']++;

        var oddCount = 0;
        foreach (var count in counter)
        {
            if (count % 2 == 1)
                oddCount++;
        }

        return oddCount < 2;
    }
}

public static class _266_PalindromePermutationTestCases
{
    public static string Test_1 { get; } = "code";
    public static string Test_2 { get; } = "aab";
    public static string Test_3 { get; } = "carerac";
}