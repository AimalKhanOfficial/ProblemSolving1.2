using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTemplateProject
{
    //Accepted
    //Runtime: 172 ms, faster than 27.27% of C# online submissions for Binary Search.
    //Memory Usage: 21 MB, less than 25.81% of C# online submissions for Binary Search.

    class Program
    {
        static void Main(string[] args)
        {
            var list = Search(new int[] { -1, 0, 3, 5, 9, 12 }, 2);
            Console.ReadKey();
        }

        public static int Search(int[] nums, int target)
        {
            if (nums.Length == 1) return -1;
            return ReturnIndexByBinarySearch(nums, 0, nums.Length, target);
        }

        public static int ReturnIndexByBinarySearch(int[] arr, int start, int end, int target)
        {
            if (start >= end) return -1;
            int mid = (start + end) / 2;
            if (arr[mid] == target) return mid;
            if (arr[mid] < target) return ReturnIndexByBinarySearch(arr, mid + 1, end, target);
            else return ReturnIndexByBinarySearch(arr, start, mid, target);
        }
    }
}
