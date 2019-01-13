using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProblemSolvingTemplateProject
{
    //Has Some Runtime issues with the following test case but its worth keeping here.
	/*
		["MyLinkedList","addAtHead","addAtHead","deleteAtIndex","addAtIndex","addAtTail","addAtIndex","addAtTail","addAtHead","addAtHead","addAtHead","addAtTail","addAtTail","addAtHead","addAtTail","addAtTail","addAtHead","addAtTail","deleteAtIndex","addAtTail","addAtTail","get","addAtIndex","addAtHead","get","get","addAtHead","get","addAtIndex","addAtTail","addAtIndex","addAtHead","addAtHead","addAtHead","get","addAtHead","addAtIndex","addAtTail","addAtHead","addAtIndex","get","addAtTail","addAtTail","addAtIndex","addAtIndex","addAtHead","addAtHead","get","addAtTail","addAtIndex","addAtIndex","addAtHead","deleteAtIndex","addAtIndex","addAtHead","deleteAtIndex","addAtTail","deleteAtIndex","addAtTail","addAtHead","addAtTail","addAtTail","addAtHead","addAtTail","addAtIndex","deleteAtIndex","addAtHead","addAtHead","addAtHead","addAtTail","get","addAtIndex","addAtTail","addAtTail","addAtTail","deleteAtIndex","get","addAtHead","get","get","addAtTail","deleteAtIndex","addAtTail","addAtIndex","addAtHead","addAtIndex","addAtTail","get","addAtIndex","addAtIndex","addAtHead","addAtHead","get","get","get","addAtIndex","addAtHead","addAtIndex","addAtHead","addAtTail","addAtIndex","get"]
		[[],[38],[45],[2],[1,24],[36],[3,72],[76],[7],[36],[34],[91],[69],[37],[38],[4],[66],[38],[14],[12],[32],[5],[7,5],[74],[7],[13],[11],[8],[10,9],[19],[3,76],[7],[37],[99],[10],[12],[1,20],[29],[42],[21,52],[11],[44],[47],[6,27],[31,85],[59],[57],[4],[99],[13,83],[10,34],[48],[9],[22,64],[69],[33],[5],[18],[87],[42],[1],[35],[31],[67],[36,46],[23],[64],[81],[29],[50],[23],[36,63],[8],[19],[98],[22],[28],[42],[24],[34],[32],[25],[53],[55,76],[38],[23,98],[27],[18],[44,27],[16,8],[70],[15],[9],[27],[59],[40,50],[15],[11,57],[80],[50],[23,37],[12]]
	*/
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList linkedList = new MyLinkedList();
            linkedList.AddAtHead(7);
            linkedList.AddAtHead(2);
            linkedList.AddAtHead(1);
            linkedList.AddAtIndex(3, 0);
            linkedList.DeleteAtIndex(2);
            linkedList.AddAtHead(6);
            //linkedList.DisplayLinkedList();
            linkedList.AddAtTail(4);
            //Console.WriteLine(linkedList.Get(4));
            linkedList.AddAtHead(4);
            linkedList.AddAtIndex(5, 0);
            linkedList.AddAtHead(6);
            linkedList.DisplayLinkedList();
            //Console.WriteLine(linkedList.Get(3));
            Console.Read();
        }
    }

    public class Node
    {
        public Node Next { get; set; }
        public Node Prev { get; set; }
        public int val { get; set; }

        public Node(int val)
        {
            this.val = val;
        }
    }

    public class MyLinkedList
    {
        private Node Head { get; set; }
        /** Initialize your data structure here. */
        public MyLinkedList()
        {
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (this.Head == null) return -1;

            var tmp = this.Head;
            int length = ReturnListLength(tmp);
            if (index > length || index < 0)
            {
                //If index is greater than the length, return -1
                return -1;
            }

            try
            {
                while (index - 1 >= 0 && tmp != null)
                {
                    tmp = tmp.Next;
                    index--;
                }
                return tmp.val;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            var newHead = new Node(val);
            newHead.Next = this.Head;
            newHead.Prev = null;
            this.Head = newHead;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            if (this.Head == null)
            {
                AddAtHead(val);
                return;
            }

            var lastNode = this.Head;
            Node prev = null;
            while (lastNode.Next != null)
            {
                prev = lastNode;
                lastNode = lastNode.Next;
                lastNode.Prev = prev;
            }
            var newNode = new Node(val);
            newNode.Prev = lastNode;
            lastNode.Next = newNode;
            this.Head = SetHeadToTopNodeAgain(newNode);
        }

        /** Add a node of value val before the index-th node in the linked list. 
         * If index equals to the length of linked list, the node will be appended
         * to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            //case when index is zero OR head has not been initialized at all
            if (index == 0 || this.Head == null)
            {
                AddAtHead(val);
                return;
            }

            //checkin for length of linkedList
            var tmp = this.Head;
            int length = ReturnListLength(tmp);
            //if index equal to length of linkedList, append it to the end.
            if (index == length)
            {
                AddAtTail(val);
                return;
            }
            else if (index > length || index < 0)
            {
                //If index is greater than the length, the node will not be inserted.
                return;
            }

            //Normal insert at a particular index (lies in the middle)
            int counter = 0;
            Node prev = null;
            tmp = this.Head;
            while (tmp != null)
            {
                if (counter == index)
                {
                    break;
                }
                counter++;
                prev = tmp;
                tmp = tmp.Next;
                tmp.Prev = prev;
            }

            var nodeForTmp = tmp.Prev;

            var newNode = new Node(val);
            newNode.Prev = nodeForTmp;
            newNode.Next = tmp;
            nodeForTmp.Next = newNode;

            this.Head = SetHeadToTopNodeAgain(nodeForTmp);
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            var tmp = this.Head;

            //If index is greater than the length, index is invalid
            if (index > ReturnListLength(tmp))
            {
                return;
            }

            //If its a request for deleting the first node of list
            if (index == 0)
            {
                if (this.Head != null)
                {
                    if (this.Head.Next != null)
                    {
                        this.Head = this.Head.Next;
                    }
                    else
                    {
                        //only one node is present
                        this.Head = null;
                        return;
                    }
                }
                //nothing to delete
                return;
            }

            //Normal deletion at a particular index (lies in the middle)
            int counter = 0;
            Node prev = null;
            tmp = this.Head;
            while (tmp != null)
            {
                if (counter == index)
                {
                    break;
                }
                counter++;
                prev = tmp;
                tmp = tmp.Next;
                tmp.Prev = prev;
            }

            var nodeBeforeTmp = tmp.Prev;
            if (tmp.Next != null)
            {
                nodeBeforeTmp.Next = tmp.Next;
                tmp.Next.Prev = nodeBeforeTmp;
            }
            else
            {
                nodeBeforeTmp.Next = null;
            }
            this.Head = SetHeadToTopNodeAgain(nodeBeforeTmp);
        }

        public Node SetHeadToTopNodeAgain(Node head)
        {
            while (head.Prev != null)
            {
                head = head.Prev;
            }
            return head;
        }

        public int ReturnListLength(Node tmp)
        {
            int lengthOfList = 0;
            while (tmp != null)
            {
                lengthOfList++;
                tmp = tmp.Next;
            }
            return lengthOfList;
        }

        public void DisplayLinkedList()
        {
            var tmp = this.Head;
            while (tmp != null)
            {
                Console.Write(tmp.val + " => ");
                tmp = tmp.Next;
            }
        }
    }
}
