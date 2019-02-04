using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProblemSolvingTemplateProject
{
    //Accepted.
    //Runtime: 436 ms, faster than 0.00% of C# online submissions for Insertion Sort List.
    //Memory Usage: 12.1 MB, less than 0.00% of C# online submissions for Insertion Sort List.

    class Program
    {
        static void Main(string[] args)
        {
            var head = new ListNode(4);
            head.next = new ListNode(2);
            head.next.next = new ListNode(1);
            head.next.next.next = new ListNode(3);
            var res = InsertionSortList(head);
            Console.Read();
        }
        
        public static ListNode InsertionSortList(ListNode head)
        {
            var listOfNodes = new List<int>();
            var tmp = head;
            while (tmp != null)
            {
                listOfNodes.Add(tmp.val);
                tmp = tmp.next;
            }

            var counter = 0;
            var tmpForSorting = 0;
            //perform insertion sort here
            for (var i = 0; i < listOfNodes.Count; i++)
            {
                counter = i;
                while (counter > 0)
                {
                    if (counter - 1 < 0) break; 
                    if (listOfNodes[counter - 1] > listOfNodes[counter])
                    {
                        tmpForSorting = listOfNodes[counter - 1];
                        listOfNodes[counter - 1] = listOfNodes[counter];
                        listOfNodes[counter] = tmpForSorting;
                    }
                    counter--;
                }
            }
            return ReturnLinkedList(listOfNodes, 0);
        }

        public static ListNode ReturnLinkedList(List<int> allValues, int count)
        {
            if (count == allValues.Count) return null;
            var node = new ListNode(allValues[count]);
            count = count + 1;
            node.next = ReturnLinkedList(allValues, count);
            return node;
        }

        //Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}

