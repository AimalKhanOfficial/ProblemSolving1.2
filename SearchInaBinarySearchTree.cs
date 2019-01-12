using System;
using System.Collections.Generic;

//Accepted.
//My runtime beats 62.07 % of csharp submissions.

namespace PropsProj
{
    class Program
    {
        static void Main(string[] args)
        {
            var treeNode = new TreeNode(4);
            treeNode.left = new TreeNode(2);
            treeNode.right = new TreeNode(7);
            treeNode.left.left = new TreeNode(1);
            treeNode.left.right = new TreeNode(3);

            var treeNode2 = new TreeNode(40);
            treeNode2.left = new TreeNode(20);
            treeNode2.right = new TreeNode(60);
            treeNode2.left.left = new TreeNode(10);
            treeNode2.left.right = new TreeNode(30);

            var treeNode3 = new TreeNode(4);
            treeNode3.left = new TreeNode(2);
            treeNode3.right = new TreeNode(7);
            treeNode3.left.left = new TreeNode(1);
            treeNode3.left.right = new TreeNode(3);


            TreeNode tn = SearchBST(treeNode, 2);
            TreeNode tn2 = SearchBST(treeNode2, 20);
            TreeNode tn3 = SearchBST(treeNode3, 5);
            Console.Read();
        }

        //Not my login but.. i got the idea anyway!
        public static TreeNode SearchBST(TreeNode root, int val)
        { 
            if (root == null) return null;
            if (root.val == val) return root;
            if (root.val > val) return SearchBST(root.left, val);
            return SearchBST(root.right, val);
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
