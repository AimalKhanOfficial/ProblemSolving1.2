using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingTemplateProject
{
    //Accepted
    //Runtime: 288 ms, faster than 70.51% of C# online submissions for Sort Colors.
    //Memory Usage: 14.9 MB, less than 76.92% of C# online submissions for Sort Colors.

    class Program
    {
        static void Main(string[] args)
        {
            SortColors(new int[] { 2, 0, 2, 1, 1, 0 });
            Console.ReadKey(); 
        }

        //O(N2)
        //SelectionSort
        public static void SortColors(int[] arr)
        {
            var tmp = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = 0; j < arr.Length; j++)
                {
                    if (i == j) continue;
                    if (arr[j] > arr[i])
                    {
                        tmp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = tmp;
                    }
                }
            }
        }
    }
}
