using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProblemSolvingTemplateProject
{
    //Accepted.
    //Runtime: 116 ms, faster than 41.23% of C# online submissions for Merge Two Sorted Lists.

    class Program
    {
        static void Main(string[] args)
        {
            var listNode1 = new ListNode(1);
            listNode1.next = new ListNode(2);
            listNode1.next.next = new ListNode(4);

            var listNode2 = new ListNode(1);
            listNode2.next = new ListNode(3);
            listNode2.next.next = new ListNode(4);

            var result = MergeTwoLists(listNode1, listNode2);

            Console.Read();
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var mySortedList = new List<int>();
            while(l1 != null)
            {
                mySortedList.Add(l1.val);
                l1 = l1.next;
            }
            while (l2 != null)
            {
                mySortedList.Add(l2.val);
                l2 = l2.next;
            }
            mySortedList.Sort();
            return CreateLinkedListFromCollection(0, mySortedList);
        }

        public static ListNode CreateLinkedListFromCollection(int counter, List<int> list)
        {
            if (list.Count == counter) return null;
            var listNode = new ListNode(list[counter]);
            counter++;
            listNode.next = CreateLinkedListFromCollection(counter, list);
            return listNode;
        }
    }

    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}

