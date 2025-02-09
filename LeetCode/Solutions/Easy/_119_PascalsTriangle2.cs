namespace LeetCode.Solutions.Easy;

public static class _119_PascalsTriangle2
{
    public static IList<int> Solution(int rowIndex)
    {
        var result = new List<int> { 1 };
        long prev = 1;

        for (int i = 1; i <= rowIndex; i++)
        {
            long val = prev * (rowIndex - i + 1) / i;
            result.Add((int)val);
            prev = val;
        }

        return result;
    }
}
