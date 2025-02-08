namespace LeetCode.Solutions.Easy;

public static class _1672_RichestCustomerWealth
{
    public static int Solution(int[][] accounts)
    {
        var maxWealth = 0;

        for (int i = 0; i < accounts.Length; i++)
        {
            var sum = 0;

            for (int j = 0; j < accounts[i].Length; j++)
            {
                sum += accounts[i][j];
            }

            if (sum > maxWealth)
                maxWealth = sum;
        }

        return maxWealth;
    }
}
