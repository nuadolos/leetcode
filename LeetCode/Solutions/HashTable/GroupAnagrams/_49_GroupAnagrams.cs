namespace LeetCode.Solutions.HashTable.GroupAnagrams;

public static class _49_GroupAnagrams
{
    public static IList<IList<string>> Solution(string[] strs)
    {
        var groupDictionary = new Dictionary<string, IList<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            var str = strs[i];
            var counter = new char[26];

            for (int j = 0; j < str.Length; j++)
                counter[str[j] - 'a']++;

            var key = new string(counter);

            if (groupDictionary.TryGetValue(key, out var list))
                list.Add(str);
            else
                groupDictionary[key] = [str];
        }

        return new List<IList<string>>(groupDictionary.Values);
    }
}

public static class _49_GroupAnagramsTestCases
{
    public static string[] Test_1 { get; } = ["eat", "tea", "tan", "ate", "nat", "bat"];
    public static string[] Test_2 { get; } = ["abbbbbbbbbbb", "aaaaaaaaaaab"];
}