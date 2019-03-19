using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolvingTemplateProject
{
    /// <summary>
    /// https://leetcode.com/submissions/detail/216046696/
    /// Runtime: 104 ms, faster than 80.06% of C# online submissions for Remove Linked List Elements.
    /// Memory Usage: 28.3 MB, less than 8.00% of C# online submissions for Remove Linked List Elements.
    /// </summary>

    class Program
    {
        public static void Main(string[] args)
        {
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(6);
            head.next.next.next = new ListNode(3);
            head.next.next.next.next = new ListNode(4);
            head.next.next.next.next.next = new ListNode(5);
            head.next.next.next.next.next.next = new ListNode(6);
            var res = RemoveElements(head, 6);
            Console.ReadKey();
        }

        public static ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null) return null;
            var list = new List<int>();
            var tmp = head;
            while (tmp != null)
            {
                if (tmp.val != val) list.Add(tmp.val);
                tmp = tmp.next;
            }
            return CreateLinkedList(list, 0);
        }

        public static ListNode CreateLinkedList(List<int> listNode, int count)
        {
            if (listNode.Count == count) return null;
            var node = new ListNode(listNode.ElementAt(count));
            count = count + 1;
            node.next = CreateLinkedList(listNode, count);
            return node;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}