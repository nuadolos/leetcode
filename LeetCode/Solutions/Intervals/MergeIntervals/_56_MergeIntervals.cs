namespace LeetCode.Solutions.Intervals.MergeIntervals;

public static class _56_MergeIntervals
{
    public static int[][] Solution(int[][] intervals)
    {
        if (intervals.Length < 2)
            return intervals;

        System.Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        int start = intervals[0][0], end = intervals[0][1];
        var result = new List<int[]>();
        for (int i = 1; i < intervals.Length; i++)
        {
            var curr = intervals[i];

            if (Math.Max(start, curr[0]) <= Math.Min(end, curr[1]))
            {
                end = Math.Max(end, curr[1]);
                continue;
            }

            result.Add([start, end]);
            (start, end) = (curr[0], curr[1]);
        }

        result.Add([start, end]);

        return [.. result];
    }
}

public static class _56_MergeIntervalsTestCases
{
    public static int[][] Test_1 { get; } = [[1, 3], [2, 6], [8, 10], [15, 18]];
    public static int[][] Test_2 { get; } = [[1, 4], [4, 5]];
}