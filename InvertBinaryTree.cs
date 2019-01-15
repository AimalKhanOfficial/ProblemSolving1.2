using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProblemSolvingTemplateProject
{
    //Accepted.
    //Runtime: 108 ms, faster than 89.13% of C# online submissions for Invert Binary Tree.

    class Program
    {
        static void Main(string[] args)
        {
            var treeNode = new TreeNode(1);
            treeNode.left = new TreeNode(2);
            Program p = new Program();
            TreeNode x = p.InvertTree(treeNode);
            Console.Read();
        }

        TreeNode tmp = null;
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;
            if (root.right == null && root.left == null) return root;
            tmp = null;
            tmp = root.left == null ? null : root.left;
            root.left = root.right == null ? null : root.right;
            root.right = tmp;
            InvertTree(root.right);
            InvertTree(root.left);
            return root;
        }
    }
    
    //Definition for a binary tree node.
    public class TreeNode
     {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

}

