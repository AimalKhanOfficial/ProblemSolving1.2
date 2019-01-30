using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTemplateProject
{
    //Accepted
    //Runtime: 316 ms, faster than 85.00% of C# online submissions for Transpose Matrix.
    class Program
    {
        static void Main(string[] args)
        {
            int[][] intArr = new int[3][]
            {
                new int[] {1, 2, 3 }, new int[] {4, 5, 6 }, new int[] {7, 8, 9 }
            };
            var res = Transpose(intArr);
            Console.WriteLine(res);
            Console.ReadKey(); 
        }

        public static int[][] Transpose(int[][] A)
        {
            if (A.Length <= 0) return A;
            var arrToReturn = new int[A[0].Length][];
            var count = 0;
            while (count < A[0].Length)
            {
                arrToReturn[count] = new int[A.Length];
                for (var i = 0; i < A.Length; i++)
                {
                    arrToReturn[count][i] = A[i][count];
                }
                count++;
            }
            return arrToReturn;
        }
    }
}
