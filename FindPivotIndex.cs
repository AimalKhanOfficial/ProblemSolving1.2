using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTemplateProject
{
    //Accepted.
    //Runtime: 1452 ms, faster than 3.42% of C# online submissions for Find Pivot Index.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PivotIndex(new int[] { 2, 3, 1, 0, 5, 6 }));
            Console.ReadKey(); 
        }

        public static int PivotIndex(int[] nums)
        {
            var sumToRight = 0;
            var sumToLeft = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                sumToLeft = 0;
                sumToRight = 0;
                for (var j = 0; j < i; j++)
                {
                    sumToRight += nums[j];
                }

                for (var k = i; k < nums.Length; k++)
                {
                    if (i == k)
                    {
                        continue;
                    }
                    sumToLeft += nums[k];
                }

                if (sumToRight == sumToLeft)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
