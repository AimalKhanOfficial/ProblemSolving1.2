using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace MaskingInformation
{
    //Accepted
    //Runtime: 428 ms, faster than 17.95% of C# online submissions for Find All Numbers Disappeared in an Array.
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            var x1 = FindDisappearedNumbers(arr);
            var arr2 = new int[] { 1, 1 };
            var x2 =  FindDisappearedNumbers(arr2);
            Console.Read();
        }

        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            var missingElems = new List<int>();
            var myHash = new HashSet<int>(nums);
            for (int i = 1; i <= nums.Length; i++)
            {
                if (!myHash.Contains(i)) missingElems.Add(i);
            }
            return missingElems;
        }
    }
}

