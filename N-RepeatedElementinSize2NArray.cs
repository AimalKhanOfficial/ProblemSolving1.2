using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace MaskingInformation
{
    //Accepted
    //Your runtime beats 39.18 % of csharp submissions. (N-Repeated Element in Size 2N Array)
    class Program
    {
        static void Main(string[] args)
        {
            //string tn1 = ReverseStr("hello", 2);
            //int tn2 = MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
            //int tn2 = MaxProfit(new int[] { 7, 6, 4, 3, 1 });
            //int tn2 = MaxProfit(new int[] { 2, 4, 1 });
            //int result = RepeatedNTimes(new int[] { 1, 2, 3, 3 });
            int result = RepeatedNTimes(new int[] { 2, 1, 2, 5, 3, 2 });
            //int result = RepeatedNTimes(new int[] { 5, 1, 5, 2, 5, 3, 5 });
            //N = 7
            //N / 2 = 3.5

            Console.Read();
        }

        public static int RepeatedNTimes(int[] A)
        {
            var dict = new Dictionary<int, int>();
            for (var i = 0; i < A.Length; i++)
            {
                if (!dict.Keys.Contains(A[i])) dict.Add(A[i], 1);
                else dict[A[i]] = dict[A[i]] + 1;
            }
            return dict.FirstOrDefault(a => a.Value == (A.Length % 2 == 0 ? (A.Length / 2) : Math.Ceiling((double)A.Length / 2))).Key;
        }
    }
}

