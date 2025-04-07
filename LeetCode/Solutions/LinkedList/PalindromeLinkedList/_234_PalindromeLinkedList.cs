using LeetCode.Structures;

namespace LeetCode.Solutions.LinkedList.PalindromeLinkedList;

public static class _234_PalindromeLinkedList
{
    public static bool Solution(ListNode head)
    {
        ListNode? slow = head, fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow!.next;
            fast = fast.next.next;
        }

        ListNode? prev = null, current = slow;
        while (current != null)
        {
            var tmp = current;
            current = current.next;
            tmp.next = prev;
            prev = tmp;
        }

        ListNode? left = head, right = prev;
        while (right != null)
        {
            if (left!.val != right.val)
                return false;

            left = left.next;
            right = right.next;
        }

        return true;
    }
}

public static class _234_PalindromeLinkedListTestCases
{
    public static ListNode Test_1 { get; } = new ListNode(1, new(2, new(2, new(1))));
    public static ListNode Test_2 { get; } = new ListNode(1, new(2, new(1)));
}