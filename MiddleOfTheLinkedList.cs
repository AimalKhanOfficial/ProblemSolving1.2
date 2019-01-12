using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProblemSolvingTemplateProject
{
    //Accepted.
    //Runtime: 104 ms, faster than 100.00% of C# online submissions for Middle of the Linked List.
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ListNode(1);
            list.next = new ListNode(2);
            list.next.next = new ListNode(3);
            list.next.next.next = new ListNode(4);
            list.next.next.next.next = new ListNode(5);
            //list.next.next.next.next.next = new ListNode(6);
            Console.WriteLine(MiddleNode(list));
            Console.Read();
        }

        public static ListNode MiddleNode(ListNode head)
        {
            if (head == null) return null;
            double counter = 0;
            double copyOfCounter = 0;
            counter = CountNodes(head, counter);
            copyOfCounter = counter;
            counter = counter % 2 == 0 ? (counter / 2) : Math.Ceiling((counter / 2));
            while (copyOfCounter % 2 == 0 ? counter > 0 : counter > 1)
            {
                head = head.next;
                counter--;
            }
            return head;
        }

        public static double CountNodes(ListNode head, double count)
        {
            if (head == null) return count;
            count++;
            head = head.next;
            count = CountNodes(head, count);
            return count;
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
