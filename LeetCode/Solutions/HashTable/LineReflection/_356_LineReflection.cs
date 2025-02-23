namespace LeetCode.Solutions.HashTable.LineReflection;

public static class _356_LineReflection
{
    public static bool Solution(int[][] points)
    {
        int minX = points[0][0], maxX = points[0][0];

        var hashSet = new HashSet<(int, int)>();
        foreach (var point in points)
        {
            var x = point[0];
            var y = point[1];

            if (minX > x)
                minX = x;
            else if (maxX < x)
                maxX = x;

            hashSet.Add((x, y));
        }

        var sumX = minX + maxX;
        foreach (var point in points)
        {
            if (!hashSet.Contains((sumX - point[0], point[1])))
                return false;
        }

        return true;
    }
}

public static class _356_LineReflectionTestCases
{
    public static int[][] Test_1 { get; } = [[1, 1], [-1, 1]];
    public static int[][] Test_2 { get; } = [[4, 2], [3, 1], [2, 1], [1, 2]];
}