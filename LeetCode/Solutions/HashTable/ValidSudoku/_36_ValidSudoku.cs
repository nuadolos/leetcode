namespace LeetCode.Solutions.HashTable.ValidSudoku;

public static class _36_ValidSudoku
{
    public static bool Solution(char[][] board)
    {
        var columnsLength = board.Length;
        var rowsLength = board[0].Length;

        var rows = new bool[columnsLength, rowsLength];
        var columns = new bool[columnsLength, rowsLength];
        var boxes = new bool[columnsLength, rowsLength];

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                var value = board[i][j];
                if (value == '.')
                    continue;

                var num = value - '1';
                var boxIndex = i / 3 * 3 + j / 3;

                if (columns[i, num]
                    || rows[j, num]
                    || boxes[boxIndex, num])
                    return false;

                columns[i, num] = true;
                rows[j, num] = true;
                boxes[boxIndex, num] = true;
            }
        }

        return true;
    }
}

public static class _36_ValidSudokuTestCases
{
    public static char[][] Test_1 { get; } =
        [['5','3','.','.','7','.','.','.','.']
        ,['6','.','.','1','9','5','.','.','.']
        ,['.','9','8','.','.','.','.','6','.']
        ,['8','.','.','.','6','.','.','.','3']
        ,['4','.','.','8','.','3','.','.','1']
        ,['7','.','.','.','2','.','.','.','6']
        ,['.','6','.','.','.','.','2','8','.']
        ,['.','.','.','4','1','9','.','.','5']
        ,['.','.','.','.','8','.','.','7','9']];

    public static char[][] Test_2 { get; } =
        [['8','3','.','.','7','.','.','.','.']
        ,['6','.','.','1','9','5','.','.','.']
        ,['.','9','8','.','.','.','.','6','.']
        ,['8','.','.','.','6','.','.','.','3']
        ,['4','.','.','8','.','3','.','.','1']
        ,['7','.','.','.','2','.','.','.','6']
        ,['.','6','.','.','.','.','2','8','.']
        ,['.','.','.','4','1','9','.','.','5']
        ,['.','.','.','.','8','.','.','7','9']];
}