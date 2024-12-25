using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public static class LinkedListUtils
    {
        public static ListNode CreateLinkedList(int[] values)
        {
            ListNode dummy = new ListNode(0);
            ListNode current = dummy;

            foreach (int value in values)
            {
                current._next = new ListNode(value);
                current = current._next;
            }

            return dummy._next;
        }

        public static void PrintLinkedList(ListNode head)
        {
            ListNode current = head;

            while (current != null)
            {
                Console.Write(current._val + " ");
                current = current._next;
            }

            Console.WriteLine();
        }
    }
}