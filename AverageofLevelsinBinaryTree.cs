using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolvingTemplateProject
{
    /// <summary>
    /// 
    /// Runtime: 272 ms, faster than 51.15% of C# online submissions for Average of Levels in Binary Tree.
    /// Memory Usage: 45.9 MB, less than 5.26% of C# online submissions for Average of Levels in Binary Tree.
    /// 
    /// </summary>

    class Program
    {
        public static void Main(string[] args)
        {
            var treeNode = new TreeNode(2147483647);
            treeNode.right = new TreeNode(2147483647);
            treeNode.left = new TreeNode(2147483647);
            var res = AverageOfLevels(treeNode);
            Console.ReadKey();
        }

        public static IList<double> AverageOfLevels(TreeNode root)
        {
            if (root == null) return new List<double>();
            if (root.left == null && root.right == null) return new List<double>() { root.val };

            var listofAvgValuesReturn = new List<double>();
            var registry = new List<TreeNode>();
            listofAvgValuesReturn.Add(root.val);
            registry.Add(root);
            return ReturnResult(registry, listofAvgValuesReturn);

        }

        public static IList<double> ReturnResult(List<TreeNode> registry, List<double> listofAvgValuesReturn)
        {
            if (registry.Count == 0) return listofAvgValuesReturn.ToList();
            double total = 0;
            var count = 0;
            var list = new List<TreeNode>();
            list.AddRange(registry);
            registry.Clear();
            for (var i = 0; i < list.Count; i++)
            {
                var treeNode = list[i];
                if (treeNode.left != null)
                {
                    total += (double)treeNode.left.val;
                    registry.Add(treeNode.left);
                    count++;
                }

                if (treeNode.right != null)
                {
                    total += (double)treeNode.right.val;
                    registry.Add(treeNode.right);
                    count++;
                }
            }
            if (count != 0)
            {
                listofAvgValuesReturn.Add((double)total / count);
            }
            listofAvgValuesReturn = ReturnResult(registry, listofAvgValuesReturn).ToList();
            return listofAvgValuesReturn;
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