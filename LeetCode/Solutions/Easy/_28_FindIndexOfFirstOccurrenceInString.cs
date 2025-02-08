namespace LeetCode.Solutions.Easy;

public static class _28_FindIndexOfFirstOccurrenceInString
{
    public static int Solution(string haystack, string needle)
    {
        var needleIndex = 0;

        for (var i = 0; i < haystack.Length; i++)
        {
            if (needle[needleIndex] != haystack[i])
            {
                i -= needleIndex;
                needleIndex = 0;
                continue;
            }

            needleIndex++;

            if (needleIndex == needle.Length)
                return i - needleIndex + 1;
        }

        return -1;
    }
}
