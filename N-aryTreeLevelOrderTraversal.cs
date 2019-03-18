using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolvingTemplateProject
{
    /// <summary>
    /// https://leetcode.com/submissions/detail/215799244/
    /// Runtime: 340 ms, faster than 82.22% of C# online submissions for N-ary Tree Level Order Traversal.
    /// Memory Usage: 38.6 MB, less than 60.00% of C# online submissions for N-ary Tree Level Order Traversal.
    /// </summary>

    class Program
    {
        public static void Main(string[] args)
        {
            var root = new Node(1, new List<Node>() {
                new Node(2, new List<Node>() {
                     new Node() { val = 5 },
                     new Node() { val = 6 }
                }),
                new Node(3, new List<Node>() {
                     new Node() { val = 7 },
                     new Node() { val = 8 }
                }),
                new Node() { val = 4 }
            });
            var res = LevelOrder(root);
            Console.ReadKey();
        }

        public static IList<IList<int>> LevelOrder(Node root)
        {
            if (root == null) return new List<IList<int>>();
            if (root.children == null || root.children.Count < 1) new List<IList<int>>() { new List<int>() { root.val } };
            IList<IList<int>> toReturn = new List<IList<int>>() { new List<int>() { root.val } };
            IList<IList<Node>> listOfReferences = new List<IList<Node>>() { new List<Node>() { root } };
            return GetSoln(listOfReferences, toReturn);
        }

        public static IList<IList<int>> GetSoln(IList<IList<Node>> listOfReferences, IList<IList<int>> actualValues)
        {
            if (actualValues.ElementAt(actualValues.Count - 1).Count == 0)
            {
                actualValues.RemoveAt(actualValues.Count - 1);
                return actualValues;
            }
            var list = new List<int>();
            var refList = new List<Node>();
            for (var i = 0; i < listOfReferences.ElementAt(listOfReferences.Count - 1).Count; i++)
            {
                for (var j = 0; j < listOfReferences.ElementAt(listOfReferences.Count - 1)[i]?.children?.Count; j++)
                {
                    list.Add(listOfReferences.ElementAt(listOfReferences.Count - 1)[i].children[j].val);
                    refList.Add(listOfReferences.ElementAt(listOfReferences.Count - 1)[i].children[j]);
                }
            }
            listOfReferences.Add(refList);
            actualValues.Add(list);
            return GetSoln(listOfReferences, actualValues);
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