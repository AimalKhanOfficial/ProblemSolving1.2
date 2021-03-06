﻿using System;
using System.Collections.Generic;

//Accepted.
//My runtime beats 34.78 % of csharp submissions.

namespace PropsProj
{
    class Program
    {
        static void Main(string[] args)
        {
            var node = new Node(1, new List<Node>()
            {
                new Node(3, new List<Node>() {
                    new Node(5, null),
                    new Node(6, null)
                }),
                new Node(2, null),
                new Node(4, null),
            });
            Postorder(null);
            Console.Read();
        }

        static List<int> myList = new List<int>();
        public static IList<int> Postorder(Node root)
        {
            if (root == null)
            {
                return myList;
            }

            if (root.children == null)
            {
                myList.Add(root.val);
                return null;
            }

            for (var i = 0; i < root.children.Count; i++)
            {
                Postorder(root.children[i]);
            }
            myList.Add(root.val);
            return myList;
        }
    }

    public class Node
    {
        public int val;
        public IList<Node> children;
        public Node() { }
        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }

    }
}
