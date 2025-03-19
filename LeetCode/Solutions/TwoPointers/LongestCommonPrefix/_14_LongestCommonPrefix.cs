namespace LeetCode.Solutions.TwoPointers.LongestCommonPrefix;

public static class _14_LongestCommonPrefix
{
    public static string Solution(string[] strs)
    {
        if (strs.Length == 1)
            return strs[0];

        var firstStr = strs[0];
        for (int i = 0; i < firstStr.Length; i++)
        {
            for (int j = 1; j < strs.Length; j++)
            {
                if (i >= strs[j].Length || strs[j][i] != firstStr[i])
                    return firstStr[0..i];
            }
        }

        return firstStr;
    }
}

public static class _14_LongestCommonPrefixTestCases
{
    public static string[] Test_1 { get; } = ["flower", "flow", "flight"];
    public static string[] Test_2 { get; } = ["dog", "racecar", "car"];
}