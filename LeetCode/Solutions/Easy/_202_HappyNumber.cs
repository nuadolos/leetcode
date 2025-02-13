using System.Collections;

namespace LeetCode.Solutions.Easy;

public static class _202_HappyNumber
{
    public static bool Solution(int n)
    {
        var sum = n;
        var hashSet = new BitArray(1000);

        while (sum != 1)
        {
            n = sum;
            sum = 0;

            while (n != 0)
            {
                var digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }

            if (hashSet[sum] == true)
                return false;

            hashSet[sum] = true;
        }

        return true;
    }

    // optimized solution
    //public static bool Alternative(int n)
    //{
    //    var slow = n;
    //    var fast = n;

    //    do
    //    {
    //        slow = CalcSquare(slow);
    //        fast = CalcSquare(CalcSquare(fast));
    //    }
    //    while (slow != fast);

    //    return slow == 1;
    //}

    //private static int CalcSquare(int n)
    //{
    //    var sum = 0;

    //    while (n != 0)
    //    {
    //        var digit = n % 10;
    //        sum += digit * digit;
    //        n /= 10;
    //    }

    //    return sum;
    //}
}
