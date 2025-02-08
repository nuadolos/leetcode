using System.Text;

namespace LeetCode.Solutions.Easy;

public static class _67_AddBinary
{
    public static string Solution(string a, string b)
    {
        var aIndex = a.Length - 1;
        var bIndex = b.Length - 1;
        var hasCarry = false;

        var stringBuilder = new StringBuilder();

        while (aIndex >= 0 || bIndex >= 0 || hasCarry)
        {
            var firstDigit = aIndex >= 0 && a[aIndex--] == '1';
            var secondDigit = bIndex >= 0 && b[bIndex--] == '1';

            stringBuilder = (firstDigit, secondDigit, hasCarry) switch
            {
                (false, false, false)
                    or (true, true, false)
                    or (false, true, true)
                    or (true, false, true) => stringBuilder.Insert(0, '0'),
                _ => stringBuilder.Insert(0, '1')
            };

            hasCarry = firstDigit && secondDigit || firstDigit && hasCarry || hasCarry && secondDigit;
        }

        return stringBuilder.ToString();
    }
}
