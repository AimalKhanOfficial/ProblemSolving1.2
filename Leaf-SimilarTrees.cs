using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProblemSolvingTemplateProject
{
    //Accepted.
    //Runtime: 112 ms, faster than 68.18% of C# online submissions for Leaf-Similar Trees.
	
    class Program
    {
        static void Main(string[] args)
        {

            TreeNode tr1 = new TreeNode(3);
            tr1.left = new TreeNode(5);
            tr1.right = new TreeNode(1);

            tr1.left.left = new TreeNode(6);
            tr1.left.right = new TreeNode(2);

            tr1.left.right.left = new TreeNode(7);
            tr1.left.right.right = new TreeNode(4);

            tr1.right.left = new TreeNode(9);
            tr1.right.right = new TreeNode(8);

            TreeNode tr2 = new TreeNode(3);
            tr2.left = new TreeNode(5);
            tr2.right = new TreeNode(1);
              
            tr2.left.left = new TreeNode(6);
            tr2.left.right = new TreeNode(2);
              
            tr2.left.right.left = new TreeNode(7);
            tr2.left.right.right = new TreeNode(4);
              
            tr2.right.left = new TreeNode(9);
            tr2.right.right = new TreeNode(2);

            Console.WriteLine(LeafSimilar(tr1, tr2));
            Console.Read();
        }
        
        public static bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var tree1Nodes = new List<int>();
            var tree2Nodes = new List<int>();
            tree1Nodes = getAllNodes(root1, tree1Nodes);
            tree2Nodes = getAllNodes(root2, tree2Nodes);
            if (tree1Nodes.Count != tree1Nodes.Count) return false;
            for (var i = 0; i < tree1Nodes.Count; i++)
            {
                if (tree1Nodes[i] != tree2Nodes[i]) return false;
            }
            return true;
        }

        public static List<int> getAllNodes(TreeNode tree, List<int> list)
        {
            if (tree == null) return null;
            if (tree.left == null && tree.right == null)
            {
                list.Add(tree.val);
                return list;
            }
            getAllNodes(tree.left, list);
            getAllNodes(tree.right, list);
            return list;
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
