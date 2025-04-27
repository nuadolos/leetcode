using System.Text;

namespace LeetCode.Solutions.Backtracking.LetterCombinationsOfPhoneNumber;

public static class _17_LetterCombinationsOfPhoneNumber
{
    private static string[] DigitLetters { get; } =
    [
        string.Empty, string.Empty, "abc", "def",
        "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz",
    ];

    public static IList<string> Solution(string digits)
    {
        var result = new List<string>();

        if (string.IsNullOrEmpty(digits))
            return result;

        var stringBuilder = new StringBuilder();
        Backtrack(0);
        return result;

        void Backtrack(int index)
        {
            if (index == digits.Length)
            {
                result.Add(stringBuilder.ToString());
                return;
            }

            var letters = DigitLetters[digits[index] - '0'];
            for (int i = 0; i < letters.Length; i++)
            {
                stringBuilder.Append(letters[i]);
                Backtrack(index + 1);
                stringBuilder.Length--;
            }
        }
    }
}

public static class _17_LetterCombinationsOfPhoneNumberTestCases
{
    public static string Test_1 { get; } = "23";
    public static string Test_2 { get; } = "543";
}