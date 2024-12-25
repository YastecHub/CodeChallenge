namespace CodeChallenge
{
    public class ListNode
    {
        public int _val;
        public ListNode _next;

        public ListNode(int val = 0, ListNode next = null)
        {
            _val = val;
            _next = next;
        }
    }

    public class RemoveNthFromEnd
    {
        public ListNode RemovingNthFromEnd(ListNode head, int n)
        {
            // Create a dummy node to handle edge cases
            ListNode dummy = new ListNode(0, head);
            ListNode fast = dummy;
            ListNode slow = dummy;

            // Move fast pointer n + 1 steps ahead
            for (int i = 0; i <= n; i++)
            {
                fast = fast._next;
            }

            // Move both pointers until fast reaches the end
            while (fast != null)
            {
                fast = fast._next;
                slow = slow._next;
            }

            // Remove the nth node from the end
            slow._next = slow._next._next;

            // Return the head of the modified list
            return dummy._next;
        }
    }
}
