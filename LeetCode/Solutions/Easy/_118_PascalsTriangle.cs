namespace LeetCode.Solutions.Easy;

public static class _118_PascalsTriangle
{
    public static IList<IList<int>> Solution(int numRows)
    {
        var result = new List<IList<int>> { ([1]) };

        var prevRows = result[0];
        for (int i = 1; i < numRows; i++)
        {
            var rows = new List<int> { 1 };

            for (int j = 1; j < i; j++)
            {
                rows.Add(prevRows[j - 1] + prevRows[j]);
            }

            rows.Add(1);
            result.Add(rows);
            prevRows = rows;
        }

        return result;
    }
}
