namespace LeetCode.Solutions.Easy;

public static class _1089_DuplicateZeros
{
    public static void Solution(int[] arr)
    {
        int duplicates = 0;
        int left = 0;

        while (left + duplicates < arr.Length)
        {
            if (arr[left] == 0)
            {
                if (left + duplicates == arr.Length - 1)
                {
                    arr[^1] = 0;
                    break;
                }

                duplicates++;
            }

            left++;
        }

        int next = left - 1;
        while (duplicates > 0)
        {
            var num = arr[next];

            if (num == 0)
            {
                arr[next + duplicates] = num;
                duplicates--;
            }

            arr[next + duplicates] = num;
            next--;
        }
    }
}
