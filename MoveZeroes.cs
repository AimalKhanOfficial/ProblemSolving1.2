using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace MaskingInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 0, 1, 0, 2, 0, 3, 0 };
            MoveZeroes(arr);
            Console.Read();
        }

        //Accepted
        //Your runtime beats 55.43 % of csharp submissions.

        //public static void MoveZeroes(int[] nums)
        //{
        //    var tmp = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] != 0) continue;
        //        tmp = 0;
        //        for (int j = i; j < nums.Length; j++)
        //        {
        //            if (i == j) continue;
        //            if (nums[j] != 0)
        //            {
        //                tmp = nums[j];
        //                nums[j] = nums[i];
        //                nums[i] = tmp;
        //                break;
        //            }
        //        }
        //    }
        //}

        //Accepted.
        //Runtime: 340 ms, faster than 18.48% of C# online submissions for Move Zeroes.
        //Observation: Putting in more checks didn't help :p 
        public static void MoveZeroes(int[] nums)
        {
            if (nums.Length == 0) return;
            var tmp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0) continue;
                tmp = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    if (i == j || nums[j] == 0) continue;
                    if (nums[j] != 0)
                    {
                        tmp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = tmp;
                        break;
                    }
                }
            }
        }
    }
}

