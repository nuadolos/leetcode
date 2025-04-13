namespace LeetCode.Solutions.Intervals.CarPooling;

public static class _1094_CarPooling
{
    public static bool Solution(int[][] trips, int capacity)
    {
        var tripsList = new List<int[]>();
        foreach (var trip in trips)
        {
            var passengers = trip[0];

            if (passengers > capacity)
                return false;

            tripsList.Add([trip[1], passengers]);
            tripsList.Add([trip[2], -passengers]);
        }

        tripsList.Sort((a, b) =>
        {
            if (a[0] == b[0])
                return a[1].CompareTo(b[1]);

            return a[0].CompareTo(b[0]);
        });

        var currPassengers = 0;
        foreach (var trip in tripsList)
        {
            currPassengers += trip[1];
            if (currPassengers > capacity)
                return false;
        }

        return true;
    }
}

public static class _1094_CarPoolingTestCases
{
    public static (int[][] Trips, int Capacity) Test_1 { get; } = ([[2, 1, 5], [3, 3, 7]], 4);
    public static (int[][] Trips, int Capacity) Test_2 { get; } = ([[2, 1, 5], [3, 5, 7]], 3);
}