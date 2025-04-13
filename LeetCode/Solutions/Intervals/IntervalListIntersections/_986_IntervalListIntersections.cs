namespace LeetCode.Solutions.Intervals.IntervalListIntersections;

public static class _986_IntervalListIntersections
{
    public static int[][] Solution(int[][] firstList, int[][] secondList)
    {
        if (firstList.Length == 0 || secondList.Length == 0)
            return [];

        int firstIndex = 0, secondIndex = 0;
        var result = new List<int[]>();
        while (firstIndex < firstList.Length
            && secondIndex < secondList.Length)
        {
            var firstInterval = firstList[firstIndex];
            var secondInterval = secondList[secondIndex];

            var a = Math.Max(firstInterval[0], secondInterval[0]);
            var b = Math.Min(firstInterval[1], secondInterval[1]);

            if (a <= b)
                result.Add([a, b]);

            if (firstInterval[1] < secondInterval[1])
                firstIndex++;
            else
                secondIndex++;
        }

        return [.. result];
    }
}

public static class _986_IntervalListIntersectionsTestCases
{
    public static (int[][] FirstList, int[][] SecondList) Test_1 { get; } =
        ([[0, 2], [5, 10], [13, 23], [24, 25]], [[1, 5], [8, 12], [15, 24], [25, 26]]);

    public static (int[][] FirstList, int[][] SecondList) Test_2 { get; } = ([[1, 3], [5, 9]], []);
}