using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace MaskingInformation
{
    //Accepted
    //Runtime: 112 ms, faster than 50.91% of C# online submissions for Reverse Linked List.
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new ListNode(1);
            linkedList.next = new ListNode(2);
            linkedList.next.next = new ListNode(3);
            linkedList.next.next.next = new ListNode(4);
            linkedList.next.next.next.next = new ListNode(5);
            ListNode node = ReverseList(linkedList);
            Console.Read();
        }

        public static ListNode ReverseList(ListNode head)
        {
            if (head == null) return null;
            var list = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }
            list.Reverse();
            head = PrepareList(list, 0);
            return head;
        }

        public static ListNode PrepareList(List<int> allValues, int counter)
        {
            if (counter == allValues.Count) return null;
            var newNode = new ListNode(allValues[counter]);
            counter++;
            newNode.next = PrepareList(allValues, counter);
            return newNode;
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

