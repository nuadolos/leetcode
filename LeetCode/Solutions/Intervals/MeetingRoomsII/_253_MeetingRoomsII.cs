namespace LeetCode.Solutions.Intervals.MeetingRoomsII;

public static class _253_MeetingRoomsII
{
    public static int Solution(int[][] intervals)
    {
        if (intervals.Length < 2)
            return intervals.Length;

        var points = new List<int[]>();
        foreach (var interval in intervals)
        {
            points.Add([interval[0], 1]);
            points.Add([interval[1], -1]);
        }

        points.Sort((a, b) =>
        {
            if (a[0] == b[0])
                return a[1].CompareTo(b[1]);

            return a[0].CompareTo(b[0]);
        });

        int maxRooms = 0, currRooms = 0;
        foreach (var point in points)
        {
            currRooms += point[1];
            maxRooms = Math.Max(maxRooms, currRooms);
        }

        return maxRooms;
    }
}

public static class _253_MeetingRoomsIITestCases
{
    public static int[][] Test_1 { get; } = [[0, 30], [5, 10], [15, 20]];
    public static int[][] Test_2 { get; } = [[7, 10], [2, 4]];
}