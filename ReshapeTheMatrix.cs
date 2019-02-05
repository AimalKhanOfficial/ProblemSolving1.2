using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTemplateProject
{
    //Accepted
    //Runtime: 164 ms, faster than 0.00% of C# online submissions for Reshape the Matrix.
    //Memory Usage: 14.8 MB, less than 7.89% of C# online submissions for Reshape the Matrix.
    class Program
    {
        static void Main(string[] args)
        {
            var list = MatrixReshape(new int[,] { { 1, 2, 3 }, { 4, 5, 6 } }, 3, 2);
            //var list = MatrixReshape(new int[,] { { 1, 2 }, { 3, 4 } }, 2, 4); //works
            Console.ReadKey();
        }

        public static int[,] MatrixReshape(int[,] nums, int r, int c)
        {
            if (nums.GetLength(0) <= r && nums.GetLength(1) <= c) return nums;
            var newArr = new int[r, c];
            int rowPointer = 0;
            int colPointer = 0;
            for (var i = 0; i < nums.GetLength(0); i++)
            {
                for (var j = 0; j < nums.GetLength(1); j++)
                {
                    newArr[rowPointer, colPointer] = nums[i, j];
                    colPointer++;
                    if (colPointer >= c)
                    {
                        colPointer = 0;
                        rowPointer++;
                    }
                }
            }
            return newArr;
        }
    }
}
