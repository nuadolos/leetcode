using LeetCode.Structures;

namespace LeetCode.Solutions.LinkedList.RemoveNthNodeFromEndOfList;

public static class _19_RemoveNthNodeFromEndOfList
{
    public static ListNode Solution(ListNode head, int n)
    {
        var dummy = new ListNode(0, head);

        var fast = dummy;
        for (int i = 0; i <= n; i++)
            fast = fast!.next;

        var slow = dummy;
        while (fast != null)
        {
            slow = slow!.next;
            fast = fast.next;
        }

        slow!.next = slow.next!.next;

        return dummy.next!;
    }
}

public static class _19_RemoveNthNodeFromEndOfListTestCases
{
    public static (ListNode Head, int N) Test_1 { get; } = (new(1, new(2, new(3, new(4, new(5))))), 2);
    public static (ListNode Head, int N) Test_2 { get; } = (new(1, new(2)), 2);
}