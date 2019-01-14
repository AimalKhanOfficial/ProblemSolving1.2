using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace MaskingInformation
{
    //Accepted.
    //Your runtime beats 64.10 % of csharp submissions.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SortArrayByParityII(new int[] { 1, 4, 4, 3, 0, 3 }));
            Console.Read();
        }

        public static int[] SortArrayByParityII(int[] A)
        {
            var tmp = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (A[i] % 2 == 0)
                    {
                        continue;
                    }
                    else
                    {
                        for (int j = i; j < A.Length; j++)
                        {
                            if (i == j) continue;
                            if (A[j] % 2 == 0)
                            {
                                tmp = A[j];
                                A[j] = A[i];
                                A[i] = tmp;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    if (A[i] % 2 != 0)
                    {
                        continue;
                    }
                    else
                    {
                        for (int j = i; j < A.Length; j++)
                        {
                            if (i == j) continue;
                            if (A[j] % 2 != 0)
                            {
                                tmp = A[j];
                                A[j] = A[i];
                                A[i] = tmp;
                                break;
                            }
                        }
                    }
                }
            }
            return A;
        }
    }
}

