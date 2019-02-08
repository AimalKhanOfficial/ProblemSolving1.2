using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolvingTemplateProject
{
    /// <summary>
    /// Runtime: 496 ms, faster than 99.22% of C# online submissions for Sum of Even Numbers After Queries.
    /// Memory Usage: 34.7 MB, less than 100.00% of C# online submissions for Sum of Even Numbers After Queries.
    /// </summary>
    class Program
    {
        public static void Main(string[] args)
        {
            var dualArr = new int[4][];
            dualArr[0] = new int[] { 1, 0 };
            dualArr[1] = new int[] { -3, 1 };
            dualArr[2] = new int[] { -4, 0 };
            dualArr[3] = new int[] { 2, 3 };
            var arr = SumEvenAfterQueries(new int[] { 1, 2, 3, 4 }, dualArr);
            Console.ReadKey();
        }

        public static int[] SumEvenAfterQueries(int[] A, int[][] queries)
        {
            if (queries.Length == 0) return A;
            var extraArr = new int[A.Length];
            var extraVar = 0;
            var pointerForInserion = -1;
            for (var k = 0; k < A.Length; k++)
            {
                if (A[k] % 2 == 0)
                {
                    extraVar += A[k];
                }
            }
            for (var i = 0; i < queries.Length; i++)
            {
                if (queries[i][1] < A.Length)
                {
                    if (A[queries[i][1]] % 2 == 0) extraVar -= A[queries[i][1]];
                    A[queries[i][1]] += queries[i][0];
                    if (A[queries[i][1]] % 2 == 0) extraVar += A[queries[i][1]];
                    pointerForInserion++;
                    extraArr[pointerForInserion] = extraVar;
                }
            }
            return extraArr;
        }
    }
}
