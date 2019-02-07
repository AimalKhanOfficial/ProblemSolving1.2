using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolvingTemplateProject
{ 
    /// <summary>
    /// Runtime: 112 ms, faster than 61.73% of C# online submissions for Univalued Binary Tree.
    /// Memory Usage: 9.3 MB, less than 25.66% of C# online submissions for Univalued Binary Tree.
    /// </summary>
    class Program
    {
        public static void Main(string[] args)
        {
            var tree = new TreeNode(2);
            tree.left = new TreeNode(2);
            tree.right = new TreeNode(2);

            tree.left.left = new TreeNode(5);
            tree.left.right = new TreeNode(2);

            var x = IsUnivalTree(tree);
            Console.WriteLine(x);
            Console.ReadKey();
        }

        public static bool IsUnivalTree(TreeNode root)
        {
            var hash = CheckTree(root, root.val, new HashSet<int>());
            return hash.Count > 1 ? false : true;
        }

        //0 (ran outa Children), 1 (All good), 2 (Not all the Nodes have the same value)
        public static HashSet<int> CheckTree(TreeNode root, int valueToCheck, HashSet<int> values)
        {
            if (root == null) return values;
            if (values.Count > 1) return values; 
            values.Add(root.val);
            CheckTree(root.right, valueToCheck, values);
            CheckTree(root.left, valueToCheck, values);
            return values;
        }
    }
    
   //Definition for a binary tree node.
   public class TreeNode {
       public int val;
       public TreeNode left;
       public TreeNode right;
       public TreeNode(int x) { val = x; }
   }
}
