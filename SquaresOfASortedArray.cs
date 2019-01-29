using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTemplateProject
{
    //Accepted
    //Runtime: 364 ms, faster than 73.05% of C# online submissions for Squares of a Sorted Array.
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { -4, -1, 0, 3, 10 };
            var res = SortedSquares(array);
            //Console.WriteLine();
            Console.ReadKey(); 
        }

        public static int[] SortedSquares(int[] A)
        {
            for (var i = 0; i < A.Length; i++)
            {
                A[i] *= A[i];
            }
            var list = A.ToList();
            list.Sort();
            return list.ToArray();
        }
    }
}
