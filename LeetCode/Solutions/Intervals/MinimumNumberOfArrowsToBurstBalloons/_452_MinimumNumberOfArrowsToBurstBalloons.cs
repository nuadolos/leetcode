namespace LeetCode.Solutions.Intervals.MinimumNumberOfArrowsToBurstBalloons;

public static class _452_MinimumNumberOfArrowsToBurstBalloons
{
    public static int Solution(int[][] points)
    {
        System.Array.Sort(points, (a, b) => a[0].CompareTo(b[0]));

        int start = points[0][0], end = points[0][1];
        var result = 1;
        for (int i = 1; i < points.Length; i++)
        {
            var curr = points[i];

            var a = Math.Max(start, curr[0]);
            var b = Math.Min(end, curr[1]);

            if (a <= b)
            {
                (start, end) = (a, b);
                continue;
            }

            result++;
            (start, end) = (curr[0], curr[1]);
        }

        return result;
    }
}

public static class _452_MinimumNumberOfArrowsToBurstBalloonsTestCases
{
    public static int[][] Test_1 { get; } = [[10, 16], [2, 8], [1, 6], [7, 12]];
    public static int[][] Test_2 { get; } = [[1, 2], [3, 4], [5, 6], [7, 8]];
}