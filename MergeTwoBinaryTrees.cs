using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolvingTemplateProject
{
    /// <summary>
    /// https://leetcode.com/submissions/detail/215020540/
    /// Runtime: 112 ms, faster than 100.00% of C# online submissions for Merge Two Binary Trees.
    /// Memory Usage: 26.1 MB, less than 6.67% of C# online submissions for Merge Two Binary Trees.
    /// </summary>

    class Program
    {
        public static void Main(string[] args)
        {
            var t1 = new TreeNode(1);
            t1.left = new TreeNode(3);
            t1.right = new TreeNode(2);
            t1.left.left = new TreeNode(5);

            var t2 = new TreeNode(2);
            t2.left = new TreeNode(1);
            t2.right = new TreeNode(3);
            t2.left.right = new TreeNode(4);
            t2.right.right = new TreeNode(7);
            var result = MergeTrees(t1, t2);

            Console.ReadKey();
        }

        public static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null) return null;
            else if (t1 == null && t2 != null) t1 = new TreeNode(t2.val);
            else if (t1 != null && t2 == null) { /*do nothing*/ }
            else t1.val = t1.val + t2.val;
            t1.left = MergeTrees(t1?.left, t2?.left);
            t1.right = MergeTrees(t1?.right, t2?.right);
            return t1;
        }
    }

    public class TreeNode
    {
         public int val;
         public TreeNode left;
         public TreeNode right;
         public TreeNode(int x) { val = x; }
     }
}
